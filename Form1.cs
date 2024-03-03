using MySql.Data.MySqlClient;

namespace konyvtar_kovacsbalazs_13slgrafikus
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>(); // Book osztályt deklaráljuk itt

        public Form1()
        {
            InitializeComponent();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=books;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, title, author, page_count, publish_year FROM books";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = reader.GetInt64("id");
                            string title = reader.GetString("title");
                            string author = reader.GetString("author");
                            int page_count = reader.GetInt32("page_count");
                            int publish_year = reader.GetInt32("publish_year");

                            Book book = new Book(id, title, author, page_count, publish_year);
                            books.Add(book);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a feldolgozás során: " + ex.Message);
                }
            }

            // Törlés elõtt feltöltjük a listbox-ot, hogy ne legyenek duplikált elemek
            listBox_konyvlista.Items.Clear();

            // A lekért adatok hozzáadása a listbox-hoz
            foreach (Book book in books)
            {
                listBox_konyvlista.Items.Add(book.Title); // Csak a címeket adjuk hozzá a listbox-hoz
            }
        }

        private void listBox_konyvlista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eseménykezelõ tartalma
        }

        private void button1_módosítás_Click(object sender, EventArgs e)
        {
            if (listBox_konyvlista.SelectedIndex != -1)
            {
                Book selectedBook = books[listBox_konyvlista.SelectedIndex];

                FormAdatok formAdatok = new FormAdatok();
                formAdatok.SetBookData(selectedBook);
                formAdatok.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            if (listBox_konyvlista.SelectedIndex != -1)
            {
                Book selectedBook = books[listBox_konyvlista.SelectedIndex];

                // Törlés végrehajtása
                books.Remove(selectedBook); // Az adott könyv eltávolítása a listából

                // További törlési mûveletek a könyv adatbázisból való eltávolításához
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott könyv!");
            }
        }

        private void button_newbook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan szeretne új könyvet felvenni?", "Új könyv felvétele", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormAdatok formAdatok = new FormAdatok();
                formAdatok.SetBookData(null); // Üres mezõkkel jelenítjük meg az ûrlapot
                if (formAdatok.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = formAdatok.GetBookData();
                    books.Add(newBook);

                    // TODO: Új könyv hozzáadása az adatbázishoz vagy a könyvek listájához

                    MessageBox.Show("Az Új könyv felvétele sikeresen megtörtént!", "Sikeres mûvelet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshBookList();
                }
            }
        }

        private void RefreshBookList()
        {
            listBox_konyvlista.Items.Clear();
            foreach (Book book in books)
            {
                listBox_konyvlista.Items.Add(book.Title);
            }
        }

        private void button_torles_Click_1(object sender, EventArgs e)
        {
            if (listBox_konyvlista.SelectedIndex != -1)
            {
                Book selectedBook = books[listBox_konyvlista.SelectedIndex];

                // Törlés végrehajtása
                books.Remove(selectedBook); // Az adott könyv eltávolítása a listából

                // További törlési mûveletek a könyv adatbázisból való eltávolításához

                MessageBox.Show("A törlés sikeresen megtörtént!", "Sikeres mûvelet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshBookList();
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott könyv!");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button_newbook_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan szeretne új könyvet felvenni?", "Új könyv felvétele", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormAdatok formAdatok = new FormAdatok();
                formAdatok.SetBookData(null); // Üres mezõkkel jelenítjük meg az ûrlapot
                if (formAdatok.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = formAdatok.GetBookData();
                    books.Add(newBook);

                    // TODO: Új könyv hozzáadása az adatbázishoz vagy a könyvek listájához

                    MessageBox.Show("Az Új könyv felvétele sikeresen megtörtént!", "Sikeres mûvelet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshBookList();
                }
            }
        }
    }
}