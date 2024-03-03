using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyvtar_kovacsbalazs_13slgrafikus
{
    public partial class FormAdatok : Form
    {
        private bool modositas = false;
        private Book selectedBook;
        public FormAdatok()
        {

            InitializeComponent();



        }
        public Book GetBookData()
        {
            Book newBook = new Book(
                0, // Id nem ismert, esetleg generálhatunk egyet
                textBox_Title.Text,
                textBox_Author.Text,
                int.Parse(textBox_page_count.Text),
                int.Parse(textBox_publish_year.Text)
            );
            return newBook;
        }



        public void SetBookData(Book selectedBook)
        {
            this.selectedBook = selectedBook; // Beállítjuk a kiválasztott könyvet
            if (selectedBook != null)
            {
                // Ha van kiválasztott könyv, beállítjuk a vezérlőkön az adatait
                textBox_Title.Text = selectedBook.Title;
                textBox_Author.Text = selectedBook.Author;
                textBox_page_count.Text = selectedBook.Page_Count.ToString();
                textBox_publish_year.Text = selectedBook.Publish_year.ToString();
                // Átállítjuk a módosítás flag-et
                modositas = true;
            }
            else
            {
                // Ha nincs kiválasztott könyv, töröljük az adatokat a vezérlőkből
                textBox_Title.Text = "";
                textBox_Author.Text = "";
                textBox_page_count.Text = "";
                textBox_publish_year.Text = "";
                // Átállítjuk a létrehozás flag-et
                modositas = false;

                // Új könyv létrehozása és a felhasználói felület frissítése
                SetBookData(new Book(0, "", "", 0, 0));
            }
        }

        // Beállítjuk a kiválasztott könyv adatait a megfelelő vezérlőkön


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAdatok_Load(object sender, EventArgs e)
        {

        }

        private void button1_mentes_Click(object sender, EventArgs e)
        {
            if (selectedBook != null)
            {
                if (modositas)
                {
                    // Módosítás végrehajtása
                    selectedBook.Title = textBox_Title.Text;
                    selectedBook.Author = textBox_Author.Text;
                    selectedBook.Page_Count = int.Parse(textBox_page_count.Text);
                    selectedBook.Publish_year = int.Parse(textBox_publish_year.Text);
                    // TODO: Módosítás végrehajtása az adatbázisban vagy a könyvek listában

                    MessageBox.Show("A Módosítás sikeresen megtörtént!", "Sikeres művelet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Új könyv létrehozása
                    selectedBook = new Book(
                        0, // Id nem ismert, esetleg generálhatunk egyet
                        textBox_Title.Text,
                        textBox_Author.Text,
                        int.Parse(textBox_page_count.Text),
                        int.Parse(textBox_publish_year.Text)
                    );
                    // TODO: Új könyv hozzáadása az adatbázishoz vagy a könyvek listájához

                    MessageBox.Show("Az Új könyv felvétele sikeresen megtörtént!", "Sikeres művelet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK; // A dialógus eredményének beállítása OK-ra
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott könyv!");
            }
        }
    }
}
