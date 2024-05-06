namespace MusicShop
{
    partial class WalletAdmin
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
            TrenutniIznos = new Label();
            UpisaniIznos = new TextBox();
            label3 = new Label();
            Unesi = new Button();
            Ponisti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(81, 44);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(186, 55);
            label1.TabIndex = 0;
            label1.Text = "Stanje novčanika:";
            // 
            // TrenutniIznos
            // 
            TrenutniIznos.AutoSize = true;
            TrenutniIznos.BackColor = Color.SandyBrown;
            TrenutniIznos.Font = new Font("Gabriola", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TrenutniIznos.ForeColor = Color.ForestGreen;
            TrenutniIznos.Location = new Point(267, 31);
            TrenutniIznos.Margin = new Padding(0);
            TrenutniIznos.Name = "TrenutniIznos";
            TrenutniIznos.Size = new Size(0, 68);
            TrenutniIznos.TabIndex = 1;
            // 
            // UpisaniIznos
            // 
            UpisaniIznos.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            UpisaniIznos.Location = new Point(120, 201);
            UpisaniIznos.Margin = new Padding(0);
            UpisaniIznos.Name = "UpisaniIznos";
            UpisaniIznos.Size = new Size(193, 53);
            UpisaniIznos.TabIndex = 2;
            UpisaniIznos.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(38, 149);
            label3.Name = "label3";
            label3.Size = new Size(365, 42);
            label3.TabIndex = 3;
            label3.Text = "Unesite iznos koji želite nadodati u svoj novčanik:";
            // 
            // Unesi
            // 
            Unesi.BackColor = Color.SandyBrown;
            Unesi.FlatAppearance.BorderSize = 0;
            Unesi.FlatStyle = FlatStyle.Flat;
            Unesi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Unesi.Location = new Point(66, 266);
            Unesi.Name = "Unesi";
            Unesi.Size = new Size(118, 45);
            Unesi.TabIndex = 4;
            Unesi.Text = "Unesi";
            Unesi.UseVisualStyleBackColor = false;
            Unesi.Click += Unesi_Click;
            // 
            // Ponisti
            // 
            Ponisti.BackColor = Color.SandyBrown;
            Ponisti.FlatAppearance.BorderSize = 0;
            Ponisti.FlatStyle = FlatStyle.Flat;
            Ponisti.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Ponisti.Location = new Point(254, 266);
            Ponisti.Name = "Ponisti";
            Ponisti.Size = new Size(118, 45);
            Ponisti.TabIndex = 5;
            Ponisti.Text = "Poništi";
            Ponisti.UseVisualStyleBackColor = false;
            Ponisti.Click += Ponisti_Click;
            // 
            // WalletAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(431, 336);
            Controls.Add(Ponisti);
            Controls.Add(Unesi);
            Controls.Add(label3);
            Controls.Add(UpisaniIznos);
            Controls.Add(TrenutniIznos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(431, 336);
            MinimumSize = new Size(431, 336);
            Name = "WalletAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WalletAdmin";
            Load += WalletAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TrenutniIznos;
        private TextBox UpisaniIznos;
        private Label label3;
        private Button Unesi;
        private Button Ponisti;
    }
}