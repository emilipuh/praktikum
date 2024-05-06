namespace MusicShop
{
    partial class WalletUser
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
            Ponisti = new Button();
            Unesi = new Button();
            label3 = new Label();
            UpisaniIznos = new TextBox();
            TrenutniIznos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Ponisti
            // 
            Ponisti.BackColor = Color.SandyBrown;
            Ponisti.FlatAppearance.BorderSize = 0;
            Ponisti.FlatStyle = FlatStyle.Flat;
            Ponisti.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Ponisti.Location = new Point(249, 263);
            Ponisti.Name = "Ponisti";
            Ponisti.Size = new Size(118, 45);
            Ponisti.TabIndex = 11;
            Ponisti.Text = "Poništi";
            Ponisti.UseVisualStyleBackColor = false;
            Ponisti.Click += Ponisti_Click;
            // 
            // Unesi
            // 
            Unesi.BackColor = Color.SandyBrown;
            Unesi.FlatAppearance.BorderSize = 0;
            Unesi.FlatStyle = FlatStyle.Flat;
            Unesi.Font = new Font("Gabriola", 13.8F, FontStyle.Bold);
            Unesi.Location = new Point(61, 263);
            Unesi.Name = "Unesi";
            Unesi.Size = new Size(118, 45);
            Unesi.TabIndex = 10;
            Unesi.Text = "Unesi";
            Unesi.UseVisualStyleBackColor = false;
            Unesi.Click += Unesi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(33, 146);
            label3.Name = "label3";
            label3.Size = new Size(365, 42);
            label3.TabIndex = 9;
            label3.Text = "Unesite iznos koji želite nadodati u svoj novčanik:";
            // 
            // UpisaniIznos
            // 
            UpisaniIznos.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            UpisaniIznos.Location = new Point(115, 198);
            UpisaniIznos.Margin = new Padding(0);
            UpisaniIznos.Name = "UpisaniIznos";
            UpisaniIznos.Size = new Size(193, 53);
            UpisaniIznos.TabIndex = 8;
            UpisaniIznos.TextAlign = HorizontalAlignment.Center;
            // 
            // TrenutniIznos
            // 
            TrenutniIznos.AutoSize = true;
            TrenutniIznos.BackColor = Color.SandyBrown;
            TrenutniIznos.Font = new Font("Gabriola", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TrenutniIznos.ForeColor = Color.ForestGreen;
            TrenutniIznos.Location = new Point(262, 28);
            TrenutniIznos.Margin = new Padding(0);
            TrenutniIznos.Name = "TrenutniIznos";
            TrenutniIznos.Size = new Size(0, 68);
            TrenutniIznos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(76, 41);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(186, 55);
            label1.TabIndex = 6;
            label1.Text = "Stanje novčanika:";
            // 
            // WalletUser
            // 
            AutoScaleDimensions = new SizeF(9F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(431, 336);
            Controls.Add(Ponisti);
            Controls.Add(Unesi);
            Controls.Add(label3);
            Controls.Add(UpisaniIznos);
            Controls.Add(TrenutniIznos);
            Controls.Add(label1);
            Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            MaximumSize = new Size(431, 336);
            MinimumSize = new Size(431, 336);
            Name = "WalletUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WalletUser";
            Load += WalletUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ponisti;
        private Button Unesi;
        private Label label3;
        private TextBox UpisaniIznos;
        private Label TrenutniIznos;
        private Label label1;
    }
}