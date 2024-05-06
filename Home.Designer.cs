namespace MusicShop
{
    partial class Home
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
            TreeNode treeNode30 = new TreeNode("Akustične gitare");
            TreeNode treeNode31 = new TreeNode("Klasične gitare");
            TreeNode treeNode32 = new TreeNode("Električne gitare");
            TreeNode treeNode33 = new TreeNode("Bas gitare");
            TreeNode treeNode34 = new TreeNode("Mandoline");
            TreeNode treeNode35 = new TreeNode("Banjo");
            TreeNode treeNode36 = new TreeNode("Ukulele");
            TreeNode treeNode37 = new TreeNode("Ostali žičani instrumenti", new TreeNode[] { treeNode34, treeNode35, treeNode36 });
            TreeNode treeNode38 = new TreeNode("Gitare", new TreeNode[] { treeNode30, treeNode31, treeNode32, treeNode33, treeNode37 });
            TreeNode treeNode39 = new TreeNode("Klaviri i pianina");
            TreeNode treeNode40 = new TreeNode("Harmonike");
            TreeNode treeNode41 = new TreeNode("Električne klavijature");
            TreeNode treeNode42 = new TreeNode("Instrumenti s tipkama", new TreeNode[] { treeNode39, treeNode40, treeNode41 });
            TreeNode treeNode43 = new TreeNode("Violine");
            TreeNode treeNode44 = new TreeNode("Viole");
            TreeNode treeNode45 = new TreeNode("Violončela");
            TreeNode treeNode46 = new TreeNode("Kontrabasi");
            TreeNode treeNode47 = new TreeNode("Gudaći instrumenti", new TreeNode[] { treeNode43, treeNode44, treeNode45, treeNode46 });
            TreeNode treeNode48 = new TreeNode("Saksofoni");
            TreeNode treeNode49 = new TreeNode("Flaute");
            TreeNode treeNode50 = new TreeNode("Klarineti");
            TreeNode treeNode51 = new TreeNode("Tromboni");
            TreeNode treeNode52 = new TreeNode("Puhači instrumenti", new TreeNode[] { treeNode48, treeNode49, treeNode50, treeNode51 });
            TreeNode treeNode53 = new TreeNode("Instrumenti", new TreeNode[] { treeNode38, treeNode42, treeNode47, treeNode52 });
            TreeNode treeNode54 = new TreeNode("Žice za gitare");
            TreeNode treeNode55 = new TreeNode("Koferi i torbe za gitare");
            TreeNode treeNode56 = new TreeNode("Koferi i torbe za klavijature");
            TreeNode treeNode57 = new TreeNode("Koferi i torbe za harmonike");
            TreeNode treeNode58 = new TreeNode("Razna oprema", new TreeNode[] { treeNode54, treeNode55, treeNode56, treeNode57 });
            prijava = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // prijava
            // 
            prijava.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prijava.BackColor = Color.Sienna;
            prijava.FlatAppearance.BorderColor = Color.Sienna;
            prijava.FlatAppearance.BorderSize = 0;
            prijava.FlatStyle = FlatStyle.Flat;
            prijava.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            prijava.ForeColor = Color.Black;
            prijava.Location = new Point(1002, 13);
            prijava.Name = "prijava";
            prijava.Size = new Size(87, 49);
            prijava.TabIndex = 15;
            prijava.Text = "Prijava";
            prijava.UseVisualStyleBackColor = false;
            prijava.Click += prijava_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Sienna;
            label2.Font = new Font("Magneto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(243, 41);
            label2.TabIndex = 12;
            label2.Text = "Music Shop";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Sienna;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1102, 78);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.AntiqueWhite;
            treeView1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeView1.Location = new Point(22, 111);
            treeView1.Name = "treeView1";
            treeNode30.Name = "akusticne";
            treeNode30.Text = "Akustične gitare";
            treeNode31.Name = "klasicne";
            treeNode31.Text = "Klasične gitare";
            treeNode32.Name = "elektricne";
            treeNode32.Text = "Električne gitare";
            treeNode33.Name = "bas";
            treeNode33.Text = "Bas gitare";
            treeNode34.Name = "mandoline";
            treeNode34.Text = "Mandoline";
            treeNode35.Name = "banjo";
            treeNode35.Text = "Banjo";
            treeNode36.Name = "ukulele";
            treeNode36.Text = "Ukulele";
            treeNode37.Name = "ostalo_zicani";
            treeNode37.Text = "Ostali žičani instrumenti";
            treeNode38.Name = "gitare";
            treeNode38.Text = "Gitare";
            treeNode39.Name = "klaviri_pianina";
            treeNode39.Text = "Klaviri i pianina";
            treeNode40.Name = "harmonike";
            treeNode40.Text = "Harmonike";
            treeNode41.Name = "elektricne_klavijature";
            treeNode41.Text = "Električne klavijature";
            treeNode42.Name = "instrumenti_tipke";
            treeNode42.Text = "Instrumenti s tipkama";
            treeNode43.Name = "violine";
            treeNode43.Text = "Violine";
            treeNode44.Name = "viole";
            treeNode44.Text = "Viole";
            treeNode45.Name = "violoncela";
            treeNode45.Text = "Violončela";
            treeNode46.Name = "kontrabasi";
            treeNode46.Text = "Kontrabasi";
            treeNode47.Name = "gudaci";
            treeNode47.Text = "Gudaći instrumenti";
            treeNode48.Name = "saksofoni";
            treeNode48.Text = "Saksofoni";
            treeNode49.Name = "flaute";
            treeNode49.Text = "Flaute";
            treeNode50.Name = "klarineti";
            treeNode50.Text = "Klarineti";
            treeNode51.Name = "tromboni";
            treeNode51.Text = "Tromboni";
            treeNode52.Name = "puhaci";
            treeNode52.Text = "Puhači instrumenti";
            treeNode53.Name = "instrumenti";
            treeNode53.Text = "Instrumenti";
            treeNode54.Name = "zice";
            treeNode54.Text = "Žice za gitare";
            treeNode55.Name = "koferi_torbe_gitare";
            treeNode55.Text = "Koferi i torbe za gitare";
            treeNode56.Name = "koferi_torbe_klavijature";
            treeNode56.Text = "Koferi i torbe za klavijature";
            treeNode57.Name = "koferi_torbe_harmonike";
            treeNode57.Text = "Koferi i torbe za harmonike";
            treeNode58.Name = "razna_oprema";
            treeNode58.Text = "Razna oprema";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode53, treeNode58 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(292, 511);
            treeView1.TabIndex = 16;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 648);
            ControlBox = false;
            Controls.Add(treeView1);
            Controls.Add(prijava);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 670);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1100, 485);
            Name = "Home";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button prijava;
        private Label label2;
        private PictureBox pictureBox2;
        private TreeView treeView1;
    }
}