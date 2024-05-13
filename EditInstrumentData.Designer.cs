namespace MusicShop
{
    partial class EditInstrumentData
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
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            Kategorija = new ComboBox();
            NovaSlika = new PictureBox();
            TextBoxCijena = new TextBox();
            TextBoxNaziv = new TextBox();
            StaraSlika = new PictureBox();
            TrenutnaKategorija = new Label();
            TrenutniNaziv = new Label();
            TrenutnaCijena = new Label();
            AzurirajPodatke = new Button();
            Ponisti = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NovaSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StaraSlika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(224, 55);
            label1.TabIndex = 0;
            label1.Text = "Uređivanje proizvoda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 13.8F);
            label4.Location = new Point(52, 154);
            label4.Name = "label4";
            label4.Size = new Size(94, 42);
            label4.TabIndex = 15;
            label4.Text = "Kategorija:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gabriola", 13.8F);
            label5.Location = new Point(52, 385);
            label5.Name = "label5";
            label5.Size = new Size(55, 42);
            label5.TabIndex = 14;
            label5.Text = "Slika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gabriola", 13.8F);
            label3.Location = new Point(52, 309);
            label3.Name = "label3";
            label3.Size = new Size(66, 42);
            label3.TabIndex = 13;
            label3.Text = "Cijena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gabriola", 13.8F);
            label2.Location = new Point(52, 234);
            label2.Name = "label2";
            label2.Size = new Size(61, 42);
            label2.TabIndex = 12;
            label2.Text = "Naziv:";
            // 
            // Kategorija
            // 
            Kategorija.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Kategorija.FormattingEnabled = true;
            Kategorija.Items.AddRange(new object[] { "Akustične gitare", "Električne gitare", "Klasične gitare", "Bas gitare", "Klaviri i pianina", "Harmonike", "Električne klavijature", "Violine", "Viole", "Violončela", "Kontrabasi", "Saksofoni", "Flaute", "Klarineti", "Tromboni", "Žice za gitare", "Koferi i torbe za gitare", "Koferi i torbe za pianina", "Koferi i torbe za harmonike" });
            Kategorija.Location = new Point(503, 154);
            Kategorija.Name = "Kategorija";
            Kategorija.Size = new Size(336, 50);
            Kategorija.TabIndex = 19;
            // 
            // NovaSlika
            // 
            NovaSlika.BackColor = SystemColors.Window;
            NovaSlika.Location = new Point(503, 388);
            NovaSlika.Name = "NovaSlika";
            NovaSlika.Size = new Size(336, 274);
            NovaSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            NovaSlika.TabIndex = 18;
            NovaSlika.TabStop = false;
            // 
            // TextBoxCijena
            // 
            TextBoxCijena.Font = new Font("Gabriola", 13.8F);
            TextBoxCijena.Location = new Point(503, 312);
            TextBoxCijena.Name = "TextBoxCijena";
            TextBoxCijena.Size = new Size(336, 47);
            TextBoxCijena.TabIndex = 17;
            // 
            // TextBoxNaziv
            // 
            TextBoxNaziv.Font = new Font("Gabriola", 13.8F);
            TextBoxNaziv.Location = new Point(503, 232);
            TextBoxNaziv.Name = "TextBoxNaziv";
            TextBoxNaziv.Size = new Size(336, 47);
            TextBoxNaziv.TabIndex = 16;
            // 
            // StaraSlika
            // 
            StaraSlika.BackColor = SystemColors.Window;
            StaraSlika.Location = new Point(138, 388);
            StaraSlika.Name = "StaraSlika";
            StaraSlika.Size = new Size(336, 274);
            StaraSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            StaraSlika.TabIndex = 20;
            StaraSlika.TabStop = false;
            // 
            // TrenutnaKategorija
            // 
            TrenutnaKategorija.AutoSize = true;
            TrenutnaKategorija.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            TrenutnaKategorija.Location = new Point(156, 154);
            TrenutnaKategorija.Name = "TrenutnaKategorija";
            TrenutnaKategorija.Size = new Size(65, 42);
            TrenutnaKategorija.TabIndex = 21;
            TrenutnaKategorija.Text = "label6";
            // 
            // TrenutniNaziv
            // 
            TrenutniNaziv.AutoSize = true;
            TrenutniNaziv.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            TrenutniNaziv.Location = new Point(156, 234);
            TrenutniNaziv.Name = "TrenutniNaziv";
            TrenutniNaziv.Size = new Size(65, 42);
            TrenutniNaziv.TabIndex = 22;
            TrenutniNaziv.Text = "label7";
            // 
            // TrenutnaCijena
            // 
            TrenutnaCijena.AutoSize = true;
            TrenutnaCijena.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            TrenutnaCijena.Location = new Point(156, 309);
            TrenutnaCijena.Name = "TrenutnaCijena";
            TrenutnaCijena.Size = new Size(65, 42);
            TrenutnaCijena.TabIndex = 23;
            TrenutnaCijena.Text = "label8";
            // 
            // AzurirajPodatke
            // 
            AzurirajPodatke.BackColor = Color.SandyBrown;
            AzurirajPodatke.FlatAppearance.BorderSize = 0;
            AzurirajPodatke.FlatStyle = FlatStyle.Flat;
            AzurirajPodatke.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            AzurirajPodatke.Location = new Point(533, 728);
            AzurirajPodatke.Name = "AzurirajPodatke";
            AzurirajPodatke.Size = new Size(191, 57);
            AzurirajPodatke.TabIndex = 24;
            AzurirajPodatke.Text = "Ažuriraj podatke";
            AzurirajPodatke.UseVisualStyleBackColor = false;
            AzurirajPodatke.Click += AzurirajPodatke_Click;
            // 
            // Ponisti
            // 
            Ponisti.BackColor = Color.SandyBrown;
            Ponisti.FlatAppearance.BorderSize = 0;
            Ponisti.FlatStyle = FlatStyle.Flat;
            Ponisti.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Ponisti.Location = new Point(745, 728);
            Ponisti.Name = "Ponisti";
            Ponisti.Size = new Size(94, 57);
            Ponisti.TabIndex = 25;
            Ponisti.Text = "Poništi";
            Ponisti.UseVisualStyleBackColor = false;
            Ponisti.Click += Ponisti_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gabriola", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 238);
            button1.Location = new Point(503, 668);
            button1.Name = "button1";
            button1.Size = new Size(140, 54);
            button1.TabIndex = 26;
            button1.Text = "Učitaj sliku";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditInstrumentData
            // 
            AutoScaleDimensions = new SizeF(9F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(883, 797);
            Controls.Add(button1);
            Controls.Add(Ponisti);
            Controls.Add(AzurirajPodatke);
            Controls.Add(TrenutnaCijena);
            Controls.Add(TrenutniNaziv);
            Controls.Add(TrenutnaKategorija);
            Controls.Add(StaraSlika);
            Controls.Add(Kategorija);
            Controls.Add(NovaSlika);
            Controls.Add(TextBoxCijena);
            Controls.Add(TextBoxNaziv);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            Name = "EditInstrumentData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditInstrumentData";
            Load += EditInstrumentData_Load;
            ((System.ComponentModel.ISupportInitialize)NovaSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)StaraSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox Kategorija;
        private PictureBox NovaSlika;
        private TextBox TextBoxCijena;
        private TextBox TextBoxNaziv;
        private PictureBox StaraSlika;
        private Label TrenutnaKategorija;
        private Label TrenutniNaziv;
        private Label TrenutnaCijena;
        private Button AzurirajPodatke;
        private Button Ponisti;
        private Button button1;
    }
}