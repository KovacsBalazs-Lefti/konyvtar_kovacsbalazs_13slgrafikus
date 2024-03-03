using MySql.Data.MySqlClient;

namespace konyvtar_kovacsbalazs_13slgrafikus
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>(); // Book oszt�lyt deklar�ljuk itt

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
                    Console.WriteLine("Hiba a feldolgoz�s sor�n: " + ex.Message);
                }
            }

            // T�rl�s el�tt felt�ltj�k a listbox-ot, hogy ne legyenek duplik�lt elemek
            listBox_konyvlista.Items.Clear();

            // A lek�rt adatok hozz�ad�sa a listbox-hoz
            foreach (Book book in books)
            {
                listBox_konyvlista.Items.Add(book.Title); // Csak a c�meket adjuk hozz� a listbox-hoz
            }
        }

        private void listBox_konyvlista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Esem�nykezel� tartalma
        }

        private void button1_m�dos�t�s_Click(object sender, EventArgs e)
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

                // T�rl�s v�grehajt�sa
                books.Remove(selectedBook); // Az adott k�nyv elt�vol�t�sa a list�b�l

                // Tov�bbi t�rl�si m�veletek a k�nyv adatb�zisb�l val� elt�vol�t�s�hoz
            }
            else
            {
                MessageBox.Show("Nincs kiv�lasztott k�nyv!");
            }
        }

        private void button_newbook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan szeretne �j k�nyvet felvenni?", "�j k�nyv felv�tele", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormAdatok formAdatok = new FormAdatok();
                formAdatok.SetBookData(null); // �res mez�kkel jelen�tj�k meg az �rlapot
                if (formAdatok.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = formAdatok.GetBookData();
                    books.Add(newBook);

                    // TODO: �j k�nyv hozz�ad�sa az adatb�zishoz vagy a k�nyvek list�j�hoz

                    MessageBox.Show("Az �j k�nyv felv�tele sikeresen megt�rt�nt!", "Sikeres m�velet", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                // T�rl�s v�grehajt�sa
                books.Remove(selectedBook); // Az adott k�nyv elt�vol�t�sa a list�b�l

                // Tov�bbi t�rl�si m�veletek a k�nyv adatb�zisb�l val� elt�vol�t�s�hoz

                MessageBox.Show("A t�rl�s sikeresen megt�rt�nt!", "Sikeres m�velet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshBookList();
            }
            else
            {
                MessageBox.Show("Nincs kiv�lasztott k�nyv!");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button_newbook_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan szeretne �j k�nyvet felvenni?", "�j k�nyv felv�tele", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormAdatok formAdatok = new FormAdatok();
                formAdatok.SetBookData(null); // �res mez�kkel jelen�tj�k meg az �rlapot
                if (formAdatok.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = formAdatok.GetBookData();
                    books.Add(newBook);

                    // TODO: �j k�nyv hozz�ad�sa az adatb�zishoz vagy a k�nyvek list�j�hoz

                    MessageBox.Show("Az �j k�nyv felv�tele sikeresen megt�rt�nt!", "Sikeres m�velet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshBookList();
                }
            }
        }
    }
}