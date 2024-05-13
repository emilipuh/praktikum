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
            TreeNode treeNode1 = new TreeNode("Akustične gitare");
            TreeNode treeNode2 = new TreeNode("Klasične gitare");
            TreeNode treeNode3 = new TreeNode("Električne gitare");
            TreeNode treeNode4 = new TreeNode("Bas gitare");
            TreeNode treeNode5 = new TreeNode("Mandoline");
            TreeNode treeNode6 = new TreeNode("Banjo");
            TreeNode treeNode7 = new TreeNode("Ukulele");
            TreeNode treeNode8 = new TreeNode("Ostali žičani instrumenti", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Gitare", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Klaviri i pianina");
            TreeNode treeNode11 = new TreeNode("Harmonike");
            TreeNode treeNode12 = new TreeNode("Električne klavijature");
            TreeNode treeNode13 = new TreeNode("Instrumenti s tipkama", new TreeNode[] { treeNode10, treeNode11, treeNode12 });
            TreeNode treeNode14 = new TreeNode("Violine");
            TreeNode treeNode15 = new TreeNode("Viole");
            TreeNode treeNode16 = new TreeNode("Violončela");
            TreeNode treeNode17 = new TreeNode("Kontrabasi");
            TreeNode treeNode18 = new TreeNode("Gudaći instrumenti", new TreeNode[] { treeNode14, treeNode15, treeNode16, treeNode17 });
            TreeNode treeNode19 = new TreeNode("Saksofoni");
            TreeNode treeNode20 = new TreeNode("Flaute");
            TreeNode treeNode21 = new TreeNode("Klarineti");
            TreeNode treeNode22 = new TreeNode("Tromboni");
            TreeNode treeNode23 = new TreeNode("Puhači instrumenti", new TreeNode[] { treeNode19, treeNode20, treeNode21, treeNode22 });
            TreeNode treeNode24 = new TreeNode("Instrumenti", new TreeNode[] { treeNode9, treeNode13, treeNode18, treeNode23 });
            TreeNode treeNode25 = new TreeNode("Žice za gitare");
            TreeNode treeNode26 = new TreeNode("Koferi i torbe za gitare");
            TreeNode treeNode27 = new TreeNode("Koferi i torbe za klavijature");
            TreeNode treeNode28 = new TreeNode("Koferi i torbe za harmonike");
            TreeNode treeNode29 = new TreeNode("Razna oprema", new TreeNode[] { treeNode25, treeNode26, treeNode27, treeNode28 });
            TreeNode treeNode30 = new TreeNode("Svi proizvodi");
            prijava = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            UkloniFilter = new Button();
            Filter = new ComboBox();
            InstrumentiPanel = new FlowLayoutPanel();
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
            prijava.Location = new Point(1102, 13);
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
            pictureBox2.Size = new Size(1202, 78);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // UkloniFilter
            // 
            UkloniFilter.Font = new Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UkloniFilter.Location = new Point(225, 111);
            UkloniFilter.Name = "UkloniFilter";
            UkloniFilter.Size = new Size(128, 45);
            UkloniFilter.TabIndex = 39;
            UkloniFilter.Text = "Ukloni filter";
            UkloniFilter.UseVisualStyleBackColor = true;
            UkloniFilter.Click += UkloniFilter_Click;
            // 
            // Filter
            // 
            Filter.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Filter.FormattingEnabled = true;
            Filter.Items.AddRange(new object[] { "Po najnižoj cijeni", "Po najvišoj cijeni" });
            Filter.Location = new Point(22, 112);
            Filter.Name = "Filter";
            Filter.Size = new Size(198, 45);
            Filter.TabIndex = 38;
            Filter.Text = "Sortiraj prema cijeni";
            Filter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // InstrumentiPanel
            // 
            InstrumentiPanel.BackColor = SystemColors.Control;
            InstrumentiPanel.BackgroundImageLayout = ImageLayout.None;
            InstrumentiPanel.Location = new Point(377, 112);
            InstrumentiPanel.Name = "InstrumentiPanel";
            InstrumentiPanel.Size = new Size(799, 602);
            InstrumentiPanel.TabIndex = 37;
            InstrumentiPanel.Paint += InstrumentiPanel_Paint;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.AntiqueWhite;
            treeView1.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeView1.Location = new Point(22, 178);
            treeView1.Name = "treeView1";
            treeNode1.Name = "akusticne";
            treeNode1.Text = "Akustične gitare";
            treeNode2.Name = "klasicne";
            treeNode2.Text = "Klasične gitare";
            treeNode3.Name = "elektricne";
            treeNode3.Text = "Električne gitare";
            treeNode4.Name = "bas";
            treeNode4.Text = "Bas gitare";
            treeNode5.Name = "mandoline";
            treeNode5.Text = "Mandoline";
            treeNode6.Name = "banjo";
            treeNode6.Text = "Banjo";
            treeNode7.Name = "ukulele";
            treeNode7.Text = "Ukulele";
            treeNode8.Name = "ostalo_zicani";
            treeNode8.Text = "Ostali žičani instrumenti";
            treeNode9.Name = "gitare";
            treeNode9.Text = "Gitare";
            treeNode10.Name = "klaviri_pianina";
            treeNode10.Text = "Klaviri i pianina";
            treeNode11.Name = "harmonike";
            treeNode11.Text = "Harmonike";
            treeNode12.Name = "elektricne_klavijature";
            treeNode12.Text = "Električne klavijature";
            treeNode13.Name = "instrumenti_tipke";
            treeNode13.Text = "Instrumenti s tipkama";
            treeNode14.Name = "violine";
            treeNode14.Text = "Violine";
            treeNode15.Name = "viole";
            treeNode15.Text = "Viole";
            treeNode16.Name = "violoncela";
            treeNode16.Text = "Violončela";
            treeNode17.Name = "kontrabasi";
            treeNode17.Text = "Kontrabasi";
            treeNode18.Name = "gudaci";
            treeNode18.Text = "Gudaći instrumenti";
            treeNode19.Name = "saksofoni";
            treeNode19.Text = "Saksofoni";
            treeNode20.Name = "flaute";
            treeNode20.Text = "Flaute";
            treeNode21.Name = "klarineti";
            treeNode21.Text = "Klarineti";
            treeNode22.Name = "tromboni";
            treeNode22.Text = "Tromboni";
            treeNode23.Name = "puhaci";
            treeNode23.Text = "Puhači instrumenti";
            treeNode24.Name = "instrumenti";
            treeNode24.Text = "Instrumenti";
            treeNode25.Name = "zice";
            treeNode25.Text = "Žice za gitare";
            treeNode26.Name = "koferi_torbe_gitare";
            treeNode26.Text = "Koferi i torbe za gitare";
            treeNode27.Name = "koferi_torbe_klavijature";
            treeNode27.Text = "Koferi i torbe za klavijature";
            treeNode28.Name = "koferi_torbe_harmonike";
            treeNode28.Text = "Koferi i torbe za harmonike";
            treeNode29.Name = "razna_oprema";
            treeNode29.Text = "Razna oprema";
            treeNode30.Name = "SviProizvodi";
            treeNode30.Text = "Svi proizvodi";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode24, treeNode29, treeNode30 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(331, 536);
            treeView1.TabIndex = 36;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            ControlBox = false;
            Controls.Add(UkloniFilter);
            Controls.Add(Filter);
            Controls.Add(InstrumentiPanel);
            Controls.Add(treeView1);
            Controls.Add(prijava);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 750);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1200, 700);
            Name = "Home";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button prijava;
        private Label label2;
        private PictureBox pictureBox2;
        private Button UkloniFilter;
        private ComboBox Filter;
        private FlowLayoutPanel InstrumentiPanel;
        private TreeView treeView1;
    }
}