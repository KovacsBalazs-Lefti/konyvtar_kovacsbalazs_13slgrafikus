namespace konyvtar_kovacsbalazs_13slgrafikus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_konyvlista = new ListBox();
            button1_módosítás = new Button();
            button_torles = new Button();
            button_newbook = new Button();
            button_read = new Button();
            SuspendLayout();
            // 
            // listBox_konyvlista
            // 
            listBox_konyvlista.Dock = DockStyle.Left;
            listBox_konyvlista.FormattingEnabled = true;
            listBox_konyvlista.ItemHeight = 28;
            listBox_konyvlista.Location = new Point(0, 0);
            listBox_konyvlista.Margin = new Padding(4);
            listBox_konyvlista.Name = "listBox_konyvlista";
            listBox_konyvlista.Size = new Size(460, 630);
            listBox_konyvlista.TabIndex = 0;
            listBox_konyvlista.SelectedIndexChanged += listBox_konyvlista_SelectedIndexChanged;
            // 
            // button1_módosítás
            // 
            button1_módosítás.Location = new Point(669, 185);
            button1_módosítás.Name = "button1_módosítás";
            button1_módosítás.Size = new Size(223, 50);
            button1_módosítás.TabIndex = 1;
            button1_módosítás.Text = "Módosítás";
            button1_módosítás.UseVisualStyleBackColor = true;
            button1_módosítás.Click += button1_módosítás_Click;
            // 
            // button_torles
            // 
            button_torles.Location = new Point(669, 264);
            button_torles.Name = "button_torles";
            button_torles.Size = new Size(223, 50);
            button_torles.TabIndex = 2;
            button_torles.Text = "Törlés";
            button_torles.UseVisualStyleBackColor = true;
            button_torles.Click += button_torles_Click_1;
            // 
            // button_newbook
            // 
            button_newbook.Location = new Point(669, 107);
            button_newbook.Name = "button_newbook";
            button_newbook.Size = new Size(223, 50);
            button_newbook.TabIndex = 3;
            button_newbook.Text = "Új Könyv felvétele";
            button_newbook.UseVisualStyleBackColor = true;
            button_newbook.Click += button_newbook_Click_1;
            // 
            // button_read
            // 
            button_read.Location = new Point(669, 31);
            button_read.Name = "button_read";
            button_read.Size = new Size(223, 50);
            button_read.TabIndex = 4;
            button_read.Text = "Listázás";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(button_read);
            Controls.Add(button_newbook);
            Controls.Add(button_torles);
            Controls.Add(button1_módosítás);
            Controls.Add(listBox_konyvlista);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Könyvtár";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_konyvlista;
        private Button button1_módosítás;
        private Button button_torles;
        private Button button_newbook;
        private Button button_read;
    }
}