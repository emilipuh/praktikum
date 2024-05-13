namespace MusicShop
{
    partial class Users
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
            PrikazKorisnika = new DataGridView();
            label1 = new Label();
            Natrag = new Button();
            Obrisi = new Button();
            PromijeniStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)PrikazKorisnika).BeginInit();
            SuspendLayout();
            // 
            // PrikazKorisnika
            // 
            PrikazKorisnika.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrikazKorisnika.BackgroundColor = Color.Bisque;
            PrikazKorisnika.BorderStyle = BorderStyle.None;
            PrikazKorisnika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PrikazKorisnika.Location = new Point(53, 155);
            PrikazKorisnika.Name = "PrikazKorisnika";
            PrikazKorisnika.RowHeadersWidth = 51;
            PrikazKorisnika.Size = new Size(553, 462);
            PrikazKorisnika.TabIndex = 0;
            PrikazKorisnika.CellContentClick += PrikazKorisnika_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(53, 55);
            label1.Name = "label1";
            label1.Size = new Size(178, 55);
            label1.TabIndex = 1;
            label1.Text = "Prikaz korisnika";
            // 
            // Natrag
            // 
            Natrag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Natrag.BackColor = Color.SandyBrown;
            Natrag.FlatAppearance.BorderColor = Color.SandyBrown;
            Natrag.FlatAppearance.BorderSize = 0;
            Natrag.FlatStyle = FlatStyle.Flat;
            Natrag.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Natrag.Location = new Point(624, 572);
            Natrag.Name = "Natrag";
            Natrag.RightToLeft = RightToLeft.No;
            Natrag.Size = new Size(164, 45);
            Natrag.TabIndex = 2;
            Natrag.Text = "Natrag";
            Natrag.UseVisualStyleBackColor = false;
            Natrag.Click += Natrag_Click;
            // 
            // Obrisi
            // 
            Obrisi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Obrisi.BackColor = Color.SandyBrown;
            Obrisi.FlatAppearance.BorderColor = Color.SandyBrown;
            Obrisi.FlatAppearance.BorderSize = 0;
            Obrisi.FlatStyle = FlatStyle.Flat;
            Obrisi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Obrisi.ImageAlign = ContentAlignment.MiddleLeft;
            Obrisi.Location = new Point(624, 219);
            Obrisi.Name = "Obrisi";
            Obrisi.RightToLeft = RightToLeft.No;
            Obrisi.Size = new Size(164, 45);
            Obrisi.TabIndex = 3;
            Obrisi.Text = "Obriši";
            Obrisi.UseVisualStyleBackColor = false;
            Obrisi.Click += Obrisi_Click;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PromijeniStatus.BackColor = Color.SandyBrown;
            PromijeniStatus.FlatAppearance.BorderColor = Color.SandyBrown;
            PromijeniStatus.FlatAppearance.BorderSize = 0;
            PromijeniStatus.FlatStyle = FlatStyle.Flat;
            PromijeniStatus.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PromijeniStatus.ImageAlign = ContentAlignment.MiddleLeft;
            PromijeniStatus.Location = new Point(624, 155);
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.RightToLeft = RightToLeft.No;
            PromijeniStatus.Size = new Size(164, 49);
            PromijeniStatus.TabIndex = 4;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseVisualStyleBackColor = false;
            PromijeniStatus.Click += PromijeniStatus_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 670);
            Controls.Add(PromijeniStatus);
            Controls.Add(Obrisi);
            Controls.Add(Natrag);
            Controls.Add(label1);
            Controls.Add(PrikazKorisnika);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 705);
            MinimumSize = new Size(800, 670);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)PrikazKorisnika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PrikazKorisnika;
        private Label label1;
        private Button Natrag;
        private Button Obrisi;
        private Button PromijeniStatus;
    }
}