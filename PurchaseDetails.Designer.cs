namespace MusicShop
{
    partial class PurchaseDetails
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Natrag = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(356, 457);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(91, 55);
            label1.TabIndex = 1;
            label1.Text = "Kupnja";
            // 
            // Natrag
            // 
            Natrag.BackColor = Color.SandyBrown;
            Natrag.FlatAppearance.BorderSize = 0;
            Natrag.FlatStyle = FlatStyle.Flat;
            Natrag.Font = new Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Natrag.Location = new Point(393, 521);
            Natrag.Name = "Natrag";
            Natrag.Size = new Size(114, 53);
            Natrag.TabIndex = 2;
            Natrag.Text = "Natrag";
            Natrag.UseVisualStyleBackColor = false;
            Natrag.Click += Natrag_Click;
            // 
            // PurchaseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(506, 601);
            Controls.Add(Natrag);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PurchaseDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PurchaseDetails";
            Load += PurchaseDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button Natrag;
    }
}