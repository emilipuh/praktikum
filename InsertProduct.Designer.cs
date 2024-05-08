namespace MusicShop
{
    partial class InsertProduct
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
            DodajProizvod = new Button();
            Ponisti = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            TextBoxNaziv = new TextBox();
            TextBoxCijena = new TextBox();
            OdaberiSliku = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            Kategorija = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(221, 55);
            label1.TabIndex = 0;
            label1.Text = "Dodavanje proizvoda";
            // 
            // DodajProizvod
            // 
            DodajProizvod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DodajProizvod.FlatAppearance.BorderSize = 0;
            DodajProizvod.FlatStyle = FlatStyle.Flat;
            DodajProizvod.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            DodajProizvod.Location = new Point(321, 740);
            DodajProizvod.Name = "DodajProizvod";
            DodajProizvod.Size = new Size(152, 48);
            DodajProizvod.TabIndex = 1;
            DodajProizvod.Text = "Dodaj";
            DodajProizvod.UseVisualStyleBackColor = true;
            DodajProizvod.Click += DodajProizvod_Click;
            // 
            // Ponisti
            // 
            Ponisti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Ponisti.FlatAppearance.BorderSize = 0;
            Ponisti.FlatStyle = FlatStyle.Flat;
            Ponisti.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Ponisti.Location = new Point(466, 739);
            Ponisti.Name = "Ponisti";
            Ponisti.Size = new Size(124, 51);
            Ponisti.TabIndex = 2;
            Ponisti.Text = "Poništi";
            Ponisti.UseVisualStyleBackColor = true;
            Ponisti.Click += Ponisti_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gabriola", 13.8F);
            label2.Location = new Point(63, 229);
            label2.Name = "label2";
            label2.Size = new Size(61, 42);
            label2.TabIndex = 3;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gabriola", 13.8F);
            label3.Location = new Point(63, 304);
            label3.Name = "label3";
            label3.Size = new Size(66, 42);
            label3.TabIndex = 4;
            label3.Text = "Cijena:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gabriola", 13.8F);
            label5.Location = new Point(63, 380);
            label5.Name = "label5";
            label5.Size = new Size(55, 42);
            label5.TabIndex = 5;
            label5.Text = "Slika:";
            // 
            // TextBoxNaziv
            // 
            TextBoxNaziv.Font = new Font("Gabriola", 13.8F);
            TextBoxNaziv.Location = new Point(163, 224);
            TextBoxNaziv.Name = "TextBoxNaziv";
            TextBoxNaziv.Size = new Size(336, 47);
            TextBoxNaziv.TabIndex = 6;
            // 
            // TextBoxCijena
            // 
            TextBoxCijena.Font = new Font("Gabriola", 13.8F);
            TextBoxCijena.Location = new Point(163, 304);
            TextBoxCijena.Name = "TextBoxCijena";
            TextBoxCijena.Size = new Size(336, 47);
            TextBoxCijena.TabIndex = 7;
            // 
            // OdaberiSliku
            // 
            OdaberiSliku.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OdaberiSliku.FlatAppearance.BorderColor = Color.Bisque;
            OdaberiSliku.FlatStyle = FlatStyle.Flat;
            OdaberiSliku.Font = new Font("Gabriola", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 238);
            OdaberiSliku.Location = new Point(163, 672);
            OdaberiSliku.Name = "OdaberiSliku";
            OdaberiSliku.Size = new Size(152, 48);
            OdaberiSliku.TabIndex = 9;
            OdaberiSliku.Text = "Odaberi sliku";
            OdaberiSliku.UseVisualStyleBackColor = true;
            OdaberiSliku.Click += OdaberiSliku_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(163, 380);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 13.8F);
            label4.Location = new Point(63, 149);
            label4.Name = "label4";
            label4.Size = new Size(94, 42);
            label4.TabIndex = 11;
            label4.Text = "Kategorija:";
            // 
            // Kategorija
            // 
            Kategorija.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Kategorija.FormattingEnabled = true;
            Kategorija.Items.AddRange(new object[] { "Gitare", "Klaviri i pianina", "Harmonike", "Električne klavijature", "Violine", "Viole", "Violončela", "Kontrabasi", "Saksofoni", "Flaute", "Klarineti", "Tromboni", "Žice za gitare", "Koferi i torbe za gitare", "Koferi i torbe za pianina", "Koferi i torbe za harmonike" });
            Kategorija.Location = new Point(163, 146);
            Kategorija.Name = "Kategorija";
            Kategorija.Size = new Size(336, 50);
            Kategorija.TabIndex = 12;
            // 
            // InsertProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(600, 800);
            Controls.Add(Kategorija);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(OdaberiSliku);
            Controls.Add(TextBoxCijena);
            Controls.Add(TextBoxNaziv);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Ponisti);
            Controls.Add(DodajProizvod);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 800);
            MinimumSize = new Size(600, 800);
            Name = "InsertProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertProduct";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button DodajProizvod;
        private Button Ponisti;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox TextBoxNaziv;
        private TextBox TextBoxCijena;
        private Button OdaberiSliku;
        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox Kategorija;
    }
}