namespace MusicShop
{
    partial class Login
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
            Prijava = new Button();
            label1 = new Label();
            label2 = new Label();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            PrikaziLozinku = new CheckBox();
            RoleComboBox = new ComboBox();
            Exit = new Label();
            Registracija = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BezPrijave = new LinkLabel();
            SuspendLayout();
            // 
            // Prijava
            // 
            Prijava.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Prijava.BackColor = Color.Chocolate;
            Prijava.Cursor = Cursors.Hand;
            Prijava.Font = new Font("Gabriola", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Prijava.Location = new Point(174, 482);
            Prijava.Name = "Prijava";
            Prijava.Size = new Size(157, 59);
            Prijava.TabIndex = 0;
            Prijava.Text = "Prijava";
            Prijava.UseVisualStyleBackColor = false;
            Prijava.Click += Prijava_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 251);
            label1.Name = "label1";
            label1.Size = new Size(148, 24);
            label1.TabIndex = 1;
            label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 351);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 2;
            label2.Text = "Lozinka";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsername.Location = new Point(82, 278);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(337, 27);
            TextBoxUsername.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxPassword.Location = new Point(82, 378);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(337, 27);
            TextBoxPassword.TabIndex = 4;
            // 
            // PrikaziLozinku
            // 
            PrikaziLozinku.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrikaziLozinku.AutoSize = true;
            PrikaziLozinku.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrikaziLozinku.Location = new Point(82, 411);
            PrikaziLozinku.Name = "PrikaziLozinku";
            PrikaziLozinku.Size = new Size(141, 23);
            PrikaziLozinku.TabIndex = 5;
            PrikaziLozinku.Text = "Prikaži lozinku";
            PrikaziLozinku.UseVisualStyleBackColor = true;
            PrikaziLozinku.CheckedChanged += PrikaziLozinku_CheckedChanged;
            // 
            // RoleComboBox
            // 
            RoleComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RoleComboBox.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleComboBox.ForeColor = SystemColors.InfoText;
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "Administrator", "Korisnik" });
            RoleComboBox.Location = new Point(82, 162);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(337, 28);
            RoleComboBox.TabIndex = 8;
            RoleComboBox.Text = "Razina prijave";
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.None;
            Exit.AutoSize = true;
            Exit.BackColor = Color.Transparent;
            Exit.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(466, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(24, 24);
            Exit.TabIndex = 9;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // Registracija
            // 
            Registracija.ActiveLinkColor = Color.Black;
            Registracija.AutoSize = true;
            Registracija.BackColor = Color.Transparent;
            Registracija.Font = new Font("Gabriola", 12F);
            Registracija.LinkColor = Color.Black;
            Registracija.Location = new Point(198, 544);
            Registracija.Name = "Registracija";
            Registracija.Size = new Size(108, 37);
            Registracija.TabIndex = 11;
            Registracija.TabStop = true;
            Registracija.Text = "Registrirajte se";
            Registracija.LinkClicked += Registracija_LinkClicked;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Magneto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 76);
            label3.Name = "label3";
            label3.Size = new Size(243, 41);
            label3.TabIndex = 12;
            label3.Text = "Music Shop";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 14);
            label4.Name = "label4";
            label4.Size = new Size(116, 51);
            label4.TabIndex = 13;
            label4.Text = "Dobrodošli";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(82, 544);
            label5.Name = "label5";
            label5.Size = new Size(110, 37);
            label5.TabIndex = 14;
            label5.Text = "Nemate račun?";
            label5.UseWaitCursor = true;
            // 
            // BezPrijave
            // 
            BezPrijave.ActiveLinkColor = Color.Black;
            BezPrijave.AutoSize = true;
            BezPrijave.BackColor = Color.SandyBrown;
            BezPrijave.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BezPrijave.LinkColor = Color.Black;
            BezPrijave.Location = new Point(312, 544);
            BezPrijave.Name = "BezPrijave";
            BezPrijave.Size = new Size(131, 37);
            BezPrijave.TabIndex = 16;
            BezPrijave.TabStop = true;
            BezPrijave.Text = "Nastavi bez prijave";
            BezPrijave.LinkClicked += BezPrijave_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 620);
            Controls.Add(BezPrijave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Registracija);
            Controls.Add(Exit);
            Controls.Add(RoleComboBox);
            Controls.Add(PrikaziLozinku);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Prijava);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(500, 620);
            MinimumSize = new Size(440, 613);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Prijava;
        private Label label1;
        private Label label2;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private CheckBox PrikaziLozinku;
        private ComboBox RoleComboBox;
        private Label Exit;
        private LinkLabel Registracija;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel BezPrijave;
    }
}