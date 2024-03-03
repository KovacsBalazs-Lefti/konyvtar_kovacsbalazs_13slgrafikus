namespace konyvtar_kovacsbalazs_13slgrafikus
{
    partial class FormAdatok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Author = new Label();
            szerzo = new Label();
            label5 = new Label();
            textBox_ID = new TextBox();
            textBox_Title = new TextBox();
            textBox_page_count = new TextBox();
            textBox_Author = new TextBox();
            textBox_publish_year = new TextBox();
            button1_mentes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 75);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 128);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(260, 180);
            Author.Name = "Author";
            Author.Size = new Size(53, 20);
            Author.TabIndex = 2;
            Author.Text = "Szerző";
            // 
            // szerzo
            // 
            szerzo.AutoSize = true;
            szerzo.Location = new Point(260, 234);
            szerzo.Name = "szerzo";
            szerzo.Size = new Size(106, 20);
            szerzo.TabIndex = 3;
            szerzo.Text = "Oldalak száma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 291);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Kiadás éve";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(372, 75);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.ReadOnly = true;
            textBox_ID.Size = new Size(194, 27);
            textBox_ID.TabIndex = 1;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(372, 128);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(194, 27);
            textBox_Title.TabIndex = 2;
            // 
            // textBox_page_count
            // 
            textBox_page_count.Location = new Point(372, 234);
            textBox_page_count.Name = "textBox_page_count";
            textBox_page_count.Size = new Size(194, 27);
            textBox_page_count.TabIndex = 4;
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(372, 180);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(194, 27);
            textBox_Author.TabIndex = 3;
            // 
            // textBox_publish_year
            // 
            textBox_publish_year.Location = new Point(372, 288);
            textBox_publish_year.Name = "textBox_publish_year";
            textBox_publish_year.Size = new Size(194, 27);
            textBox_publish_year.TabIndex = 5;
            // 
            // button1_mentes
            // 
            button1_mentes.Location = new Point(372, 350);
            button1_mentes.Name = "button1_mentes";
            button1_mentes.Size = new Size(197, 29);
            button1_mentes.TabIndex = 6;
            button1_mentes.Text = "Mentés";
            button1_mentes.UseVisualStyleBackColor = true;
            button1_mentes.Click += button1_mentes_Click;
            // 
            // FormAdatok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1_mentes);
            Controls.Add(textBox_publish_year);
            Controls.Add(textBox_Author);
            Controls.Add(textBox_page_count);
            Controls.Add(textBox_Title);
            Controls.Add(textBox_ID);
            Controls.Add(label5);
            Controls.Add(szerzo);
            Controls.Add(Author);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdatok";
            Text = "FormAdatok";
            Load += FormAdatok_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Author;
        private Label szerzo;
        private Label label5;
        private TextBox textBox_ID;
        private TextBox textBox_Title;
        private TextBox textBox_page_count;
        private TextBox textBox_Author;
        private TextBox textBox_publish_year;
        private Button button1_mentes;
    }
}