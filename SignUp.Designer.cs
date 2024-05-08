namespace MusicShop
{
    partial class SignUp
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
            PrikaziLozinku = new CheckBox();
            TextBoxLozinkaPotvrda = new TextBox();
            TextBoxPrezime = new TextBox();
            lozinka_potvrda = new Label();
            korisnicko_ime = new Label();
            TextBoxIme = new TextBox();
            ime = new Label();
            TextBoxKorisnickoIme = new TextBox();
            TextBoxLozinka = new TextBox();
            lozinka = new Label();
            Registracija = new Button();
            exit = new Label();
            label8 = new Label();
            Prijava = new LinkLabel();
            label7 = new Label();
            BezRegistracije = new LinkLabel();
            prezime = new Label();
            RazinaComboBox = new ComboBox();
            SuspendLayout();
            // 
            // PrikaziLozinku
            // 
            PrikaziLozinku.AutoSize = true;
            PrikaziLozinku.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrikaziLozinku.Location = new Point(90, 588);
            PrikaziLozinku.Name = "PrikaziLozinku";
            PrikaziLozinku.Size = new Size(141, 23);
            PrikaziLozinku.TabIndex = 14;
            PrikaziLozinku.Text = "Prikaži lozinku";
            PrikaziLozinku.UseVisualStyleBackColor = true;
            PrikaziLozinku.CheckedChanged += PrikaziLozinku_CheckedChanged_1;
            // 
            // TextBoxLozinkaPotvrda
            // 
            TextBoxLozinkaPotvrda.Location = new Point(90, 555);
            TextBoxLozinkaPotvrda.Name = "TextBoxLozinkaPotvrda";
            TextBoxLozinkaPotvrda.Size = new Size(353, 27);
            TextBoxLozinkaPotvrda.TabIndex = 13;
            // 
            // TextBoxPrezime
            // 
            TextBoxPrezime.Location = new Point(90, 297);
            TextBoxPrezime.Name = "TextBoxPrezime";
            TextBoxPrezime.Size = new Size(353, 27);
            TextBoxPrezime.TabIndex = 12;
            // 
            // lozinka_potvrda
            // 
            lozinka_potvrda.AutoSize = true;
            lozinka_potvrda.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lozinka_potvrda.Location = new Point(90, 528);
            lozinka_potvrda.Name = "lozinka_potvrda";
            lozinka_potvrda.Size = new Size(167, 24);
            lozinka_potvrda.TabIndex = 11;
            lozinka_potvrda.Text = "Ponovite lozinku";
            // 
            // korisnicko_ime
            // 
            korisnicko_ime.AutoSize = true;
            korisnicko_ime.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            korisnicko_ime.Location = new Point(90, 358);
            korisnicko_ime.Name = "korisnicko_ime";
            korisnicko_ime.Size = new Size(148, 24);
            korisnicko_ime.TabIndex = 10;
            korisnicko_ime.Text = "Korisničko ime";
            // 
            // TextBoxIme
            // 
            TextBoxIme.Location = new Point(90, 210);
            TextBoxIme.Name = "TextBoxIme";
            TextBoxIme.Size = new Size(353, 27);
            TextBoxIme.TabIndex = 17;
            // 
            // ime
            // 
            ime.AutoSize = true;
            ime.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ime.Location = new Point(90, 183);
            ime.Name = "ime";
            ime.Size = new Size(51, 24);
            ime.TabIndex = 16;
            ime.Text = "Ime ";
            // 
            // TextBoxKorisnickoIme
            // 
            TextBoxKorisnickoIme.Location = new Point(90, 385);
            TextBoxKorisnickoIme.Name = "TextBoxKorisnickoIme";
            TextBoxKorisnickoIme.Size = new Size(353, 27);
            TextBoxKorisnickoIme.TabIndex = 19;
            // 
            // TextBoxLozinka
            // 
            TextBoxLozinka.Location = new Point(90, 469);
            TextBoxLozinka.Name = "TextBoxLozinka";
            TextBoxLozinka.Size = new Size(353, 27);
            TextBoxLozinka.TabIndex = 21;
            // 
            // lozinka
            // 
            lozinka.AutoSize = true;
            lozinka.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lozinka.Location = new Point(90, 442);
            lozinka.Name = "lozinka";
            lozinka.Size = new Size(84, 24);
            lozinka.TabIndex = 20;
            lozinka.Text = "Lozinka";
            // 
            // Registracija
            // 
            Registracija.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Registracija.BackColor = Color.Chocolate;
            Registracija.Cursor = Cursors.Hand;
            Registracija.Font = new Font("Gabriola", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Registracija.Location = new Point(128, 637);
            Registracija.Name = "Registracija";
            Registracija.Size = new Size(261, 59);
            Registracija.TabIndex = 22;
            Registracija.Text = "Registracija";
            Registracija.UseVisualStyleBackColor = false;
            Registracija.Click += Registracija_Click_1;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.None;
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(490, 24);
            exit.Name = "exit";
            exit.Size = new Size(24, 24);
            exit.TabIndex = 29;
            exit.Text = "X";
            exit.Click += Exit_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Magneto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(146, 52);
            label8.Name = "label8";
            label8.Size = new Size(243, 41);
            label8.TabIndex = 31;
            label8.Text = "Music Shop";
            label8.UseWaitCursor = true;
            // 
            // Prijava
            // 
            Prijava.ActiveLinkColor = Color.Black;
            Prijava.AutoSize = true;
            Prijava.BackColor = Color.Transparent;
            Prijava.Font = new Font("Gabriola", 12F);
            Prijava.LinkColor = Color.Black;
            Prijava.Location = new Point(206, 699);
            Prijava.Name = "Prijava";
            Prijava.Size = new Size(82, 37);
            Prijava.TabIndex = 30;
            Prijava.TabStop = true;
            Prijava.Text = "Prijavite se";
            Prijava.LinkClicked += Prijava_LinkClicked;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(85, 699);
            label7.Name = "label7";
            label7.Size = new Size(97, 37);
            label7.TabIndex = 33;
            label7.Text = "Imate račun?";
            label7.UseWaitCursor = true;
            // 
            // BezRegistracije
            // 
            BezRegistracije.ActiveLinkColor = Color.Black;
            BezRegistracije.AutoSize = true;
            BezRegistracije.BackColor = Color.Transparent;
            BezRegistracije.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BezRegistracije.LinkColor = Color.Black;
            BezRegistracije.Location = new Point(307, 699);
            BezRegistracije.Name = "BezRegistracije";
            BezRegistracije.Size = new Size(158, 37);
            BezRegistracije.TabIndex = 34;
            BezRegistracije.TabStop = true;
            BezRegistracije.Text = "Nastavi bez registracije";
            // 
            // prezime
            // 
            prezime.AutoSize = true;
            prezime.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prezime.Location = new Point(90, 270);
            prezime.Name = "prezime";
            prezime.Size = new Size(84, 24);
            prezime.TabIndex = 35;
            prezime.Text = "Prezime";
            // 
            // RazinaComboBox
            // 
            RazinaComboBox.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RazinaComboBox.FormattingEnabled = true;
            RazinaComboBox.Items.AddRange(new object[] { "Administrator", "Korisnik" });
            RazinaComboBox.Location = new Point(90, 134);
            RazinaComboBox.Name = "RazinaComboBox";
            RazinaComboBox.Size = new Size(251, 28);
            RazinaComboBox.TabIndex = 36;
            RazinaComboBox.Text = "Razina registracije";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(526, 745);
            Controls.Add(RazinaComboBox);
            Controls.Add(prezime);
            Controls.Add(BezRegistracije);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(Prijava);
            Controls.Add(exit);
            Controls.Add(Registracija);
            Controls.Add(TextBoxLozinka);
            Controls.Add(lozinka);
            Controls.Add(TextBoxKorisnickoIme);
            Controls.Add(TextBoxIme);
            Controls.Add(ime);
            Controls.Add(PrikaziLozinku);
            Controls.Add(TextBoxLozinkaPotvrda);
            Controls.Add(TextBoxPrezime);
            Controls.Add(lozinka_potvrda);
            Controls.Add(korisnicko_ime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox PrikaziLozinku;
        private TextBox TextBoxLozinkaPotvrda;
        private TextBox TextBoxPrezime;
        private Label lozinka_potvrda;
        private Label korisnicko_ime;
        private TextBox TextBoxIme;
        private Label ime;
        private TextBox TextBoxKorisnickoIme;
        private TextBox TextBoxLozinka;
        private Label lozinka;
        private Button Registracija;
        private Label exit;
        private Label label8;
        private LinkLabel Prijava;
        private Label label7;
        private LinkLabel BezRegistracije;
        private Label prezime;
        private ComboBox RazinaComboBox;
    }
}