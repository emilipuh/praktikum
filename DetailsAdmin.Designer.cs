namespace MusicShop
{
    partial class DetailsAdmin
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
            AzurirajPodatke = new Button();
            Ponisti = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Ime = new Label();
            Prezime = new Label();
            KorisnickoIme = new Label();
            TextBoxFirstName = new TextBox();
            TextBoxUsername = new TextBox();
            TextBoxLastName = new TextBox();
            label = new Label();
            TextBoxNovaLozinka = new TextBox();
            NovaLozinka = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(52, 51);
            label1.Name = "label1";
            label1.Size = new Size(287, 55);
            label1.TabIndex = 0;
            label1.Text = "Prikaz korisničkih podataka";
            // 
            // AzurirajPodatke
            // 
            AzurirajPodatke.BackColor = Color.SandyBrown;
            AzurirajPodatke.FlatAppearance.BorderSize = 0;
            AzurirajPodatke.FlatStyle = FlatStyle.Flat;
            AzurirajPodatke.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AzurirajPodatke.Location = new Point(459, 538);
            AzurirajPodatke.Name = "AzurirajPodatke";
            AzurirajPodatke.Size = new Size(194, 53);
            AzurirajPodatke.TabIndex = 1;
            AzurirajPodatke.Text = "Ažuriraj podatke";
            AzurirajPodatke.UseVisualStyleBackColor = false;
            AzurirajPodatke.Click += AzurirajPodatke_Click;
            // 
            // Ponisti
            // 
            Ponisti.BackColor = Color.SandyBrown;
            Ponisti.FlatAppearance.BorderSize = 0;
            Ponisti.FlatStyle = FlatStyle.Flat;
            Ponisti.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ponisti.Location = new Point(659, 541);
            Ponisti.Name = "Ponisti";
            Ponisti.Size = new Size(124, 47);
            Ponisti.TabIndex = 2;
            Ponisti.Text = "Poništi";
            Ponisti.UseVisualStyleBackColor = false;
            Ponisti.Click += Ponisti_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Gabriola", 13.8F);
            label3.Location = new Point(52, 347);
            label3.Name = "label3";
            label3.Size = new Size(126, 42);
            label3.TabIndex = 4;
            label3.Text = "Korisničko ime:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Gabriola", 13.8F);
            label4.Location = new Point(52, 263);
            label4.Name = "label4";
            label4.Size = new Size(79, 42);
            label4.TabIndex = 5;
            label4.Text = "Prezime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SandyBrown;
            label5.Font = new Font("Gabriola", 13.8F);
            label5.Location = new Point(52, 183);
            label5.Name = "label5";
            label5.Size = new Size(48, 42);
            label5.TabIndex = 6;
            label5.Text = "Ime:";
            // 
            // Ime
            // 
            Ime.AutoSize = true;
            Ime.BackColor = Color.SandyBrown;
            Ime.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Ime.Location = new Point(90, 183);
            Ime.Name = "Ime";
            Ime.Size = new Size(0, 42);
            Ime.TabIndex = 9;
            // 
            // Prezime
            // 
            Prezime.AutoSize = true;
            Prezime.BackColor = Color.SandyBrown;
            Prezime.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Prezime.Location = new Point(121, 263);
            Prezime.Name = "Prezime";
            Prezime.Size = new Size(0, 42);
            Prezime.TabIndex = 8;
            // 
            // KorisnickoIme
            // 
            KorisnickoIme.AutoSize = true;
            KorisnickoIme.BackColor = Color.SandyBrown;
            KorisnickoIme.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            KorisnickoIme.Location = new Point(173, 347);
            KorisnickoIme.Name = "KorisnickoIme";
            KorisnickoIme.Size = new Size(0, 42);
            KorisnickoIme.TabIndex = 7;
            KorisnickoIme.Click += KorisnickoIme_Click;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.Location = new Point(459, 178);
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new Size(181, 47);
            TextBoxFirstName.TabIndex = 10;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(459, 342);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(181, 47);
            TextBoxUsername.TabIndex = 11;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new Point(459, 258);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(181, 47);
            TextBoxLastName.TabIndex = 12;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.SandyBrown;
            label.Font = new Font("Gabriola", 13.8F);
            label.Location = new Point(52, 429);
            label.Name = "label";
            label.Size = new Size(82, 42);
            label.TabIndex = 13;
            label.Text = "Lozinka: ";
            // 
            // TextBoxNovaLozinka
            // 
            TextBoxNovaLozinka.Location = new Point(459, 429);
            TextBoxNovaLozinka.Name = "TextBoxNovaLozinka";
            TextBoxNovaLozinka.Size = new Size(181, 47);
            TextBoxNovaLozinka.TabIndex = 14;
            // 
            // NovaLozinka
            // 
            NovaLozinka.AutoSize = true;
            NovaLozinka.BackColor = Color.SandyBrown;
            NovaLozinka.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            NovaLozinka.Location = new Point(121, 429);
            NovaLozinka.Name = "NovaLozinka";
            NovaLozinka.Size = new Size(0, 42);
            NovaLozinka.TabIndex = 15;
            // 
            // DetailsAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 600);
            Controls.Add(NovaLozinka);
            Controls.Add(TextBoxNovaLozinka);
            Controls.Add(label);
            Controls.Add(TextBoxLastName);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxFirstName);
            Controls.Add(Ime);
            Controls.Add(Prezime);
            Controls.Add(KorisnickoIme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Ponisti);
            Controls.Add(AzurirajPodatke);
            Controls.Add(label1);
            Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "DetailsAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailsAdmin";
            Load += DetailsAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AzurirajPodatke;
        private Button Ponisti;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Ime;
        private Label Prezime;
        private Label KorisnickoIme;
        private TextBox TextBoxFirstName;
        private TextBox TextBoxUsername;
        private TextBox TextBoxLastName;
        private Label label;
        private TextBox TextBoxNovaLozinka;
        private Label NovaLozinka;
    }
}