namespace MusicShop
{
    partial class PastPurchasesUser
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
            PrikaziRacun = new Button();
            Natrag = new Button();
            Racuni = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Racuni).BeginInit();
            SuspendLayout();
            // 
            // PrikaziRacun
            // 
            PrikaziRacun.BackColor = Color.SandyBrown;
            PrikaziRacun.FlatAppearance.BorderSize = 0;
            PrikaziRacun.FlatStyle = FlatStyle.Flat;
            PrikaziRacun.Font = new Font("Gabriola", 12F, FontStyle.Bold);
            PrikaziRacun.Location = new Point(686, 118);
            PrikaziRacun.Name = "PrikaziRacun";
            PrikaziRacun.Size = new Size(135, 61);
            PrikaziRacun.TabIndex = 7;
            PrikaziRacun.Text = "Prikaži račun";
            PrikaziRacun.UseVisualStyleBackColor = false;
            PrikaziRacun.Click += PrikaziRacun_Click;
            // 
            // Natrag
            // 
            Natrag.BackColor = Color.SandyBrown;
            Natrag.FlatAppearance.BorderSize = 0;
            Natrag.FlatStyle = FlatStyle.Flat;
            Natrag.Font = new Font("Gabriola", 12F, FontStyle.Bold);
            Natrag.Location = new Point(702, 517);
            Natrag.Name = "Natrag";
            Natrag.Size = new Size(119, 47);
            Natrag.TabIndex = 6;
            Natrag.Text = "Natrag";
            Natrag.UseVisualStyleBackColor = false;
            Natrag.Click += Natrag_Click_1;
            // 
            // Racuni
            // 
            Racuni.BackgroundColor = Color.Bisque;
            Racuni.BorderStyle = BorderStyle.None;
            Racuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Racuni.Location = new Point(30, 118);
            Racuni.Name = "Racuni";
            Racuni.RowHeadersWidth = 51;
            Racuni.Size = new Size(618, 446);
            Racuni.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 55);
            label1.TabIndex = 4;
            label1.Text = "Prošle kupnje";
            // 
            // PastPurchasesUser
            // 
            AutoScaleDimensions = new SizeF(9F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(850, 600);
            Controls.Add(PrikaziRacun);
            Controls.Add(Natrag);
            Controls.Add(Racuni);
            Controls.Add(label1);
            Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "PastPurchasesUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PastPurchasesUser";
            Load += PastPurchasesUser_Load;
            ((System.ComponentModel.ISupportInitialize)Racuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrikaziRacun;
        private Button Natrag;
        private DataGridView Racuni;
        private Label label1;
    }
}