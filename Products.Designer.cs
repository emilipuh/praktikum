namespace MusicShop
{
    partial class Products
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
            Obrisi = new Button();
            Uredi = new Button();
            DodajNovi = new Button();
            Natrag = new Button();
            PopisProizvoda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PopisProizvoda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(191, 55);
            label1.TabIndex = 0;
            label1.Text = "Pregled proizvoda";
            // 
            // Obrisi
            // 
            Obrisi.FlatAppearance.BorderSize = 0;
            Obrisi.FlatStyle = FlatStyle.Flat;
            Obrisi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Obrisi.Location = new Point(837, 148);
            Obrisi.Name = "Obrisi";
            Obrisi.Size = new Size(129, 60);
            Obrisi.TabIndex = 1;
            Obrisi.Text = "Obriši";
            Obrisi.UseVisualStyleBackColor = true;
            Obrisi.Click += Obrisi_Click;
            // 
            // Uredi
            // 
            Uredi.FlatAppearance.BorderSize = 0;
            Uredi.FlatStyle = FlatStyle.Flat;
            Uredi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Uredi.Location = new Point(837, 219);
            Uredi.Name = "Uredi";
            Uredi.Size = new Size(129, 60);
            Uredi.TabIndex = 2;
            Uredi.Text = "Uredi";
            Uredi.UseVisualStyleBackColor = true;
            Uredi.Click += Uredi_Click;
            // 
            // DodajNovi
            // 
            DodajNovi.FlatAppearance.BorderSize = 0;
            DodajNovi.FlatStyle = FlatStyle.Flat;
            DodajNovi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            DodajNovi.Location = new Point(837, 376);
            DodajNovi.Name = "DodajNovi";
            DodajNovi.Size = new Size(129, 60);
            DodajNovi.TabIndex = 3;
            DodajNovi.Text = "Dodaj novi";
            DodajNovi.UseVisualStyleBackColor = true;
            DodajNovi.Click += DodajNovi_Click;
            // 
            // Natrag
            // 
            Natrag.FlatAppearance.BorderSize = 0;
            Natrag.FlatStyle = FlatStyle.Flat;
            Natrag.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Natrag.Location = new Point(837, 678);
            Natrag.Name = "Natrag";
            Natrag.Size = new Size(129, 60);
            Natrag.TabIndex = 4;
            Natrag.Text = "Natrag";
            Natrag.UseVisualStyleBackColor = true;
            Natrag.Click += Natrag_Click;
            // 
            // PopisProizvoda
            // 
            PopisProizvoda.BackgroundColor = Color.Bisque;
            PopisProizvoda.BorderStyle = BorderStyle.None;
            PopisProizvoda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PopisProizvoda.Location = new Point(32, 148);
            PopisProizvoda.Name = "PopisProizvoda";
            PopisProizvoda.RowHeadersWidth = 51;
            PopisProizvoda.Size = new Size(778, 574);
            PopisProizvoda.TabIndex = 5;
            PopisProizvoda.CellContentClick += PopisProizvoda_CellContentClick;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(9F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1000, 770);
            Controls.Add(PopisProizvoda);
            Controls.Add(Natrag);
            Controls.Add(DodajNovi);
            Controls.Add(Uredi);
            Controls.Add(Obrisi);
            Controls.Add(label1);
            Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            MaximumSize = new Size(1000, 770);
            MinimumSize = new Size(1000, 770);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)PopisProizvoda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Obrisi;
        private Button Uredi;
        private Button DodajNovi;
        private Button Natrag;
        private DataGridView PopisProizvoda;
    }
}