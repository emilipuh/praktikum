namespace MusicShop
{
    partial class HomeUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode61 = new TreeNode("Akustične gitare");
            TreeNode treeNode62 = new TreeNode("Klasične gitare");
            TreeNode treeNode63 = new TreeNode("Električne gitare");
            TreeNode treeNode64 = new TreeNode("Bas gitare");
            TreeNode treeNode65 = new TreeNode("Mandoline");
            TreeNode treeNode66 = new TreeNode("Banjo");
            TreeNode treeNode67 = new TreeNode("Ukulele");
            TreeNode treeNode68 = new TreeNode("Ostali žičani instrumenti", new TreeNode[] { treeNode65, treeNode66, treeNode67 });
            TreeNode treeNode69 = new TreeNode("Gitare", new TreeNode[] { treeNode61, treeNode62, treeNode63, treeNode64, treeNode68 });
            TreeNode treeNode70 = new TreeNode("Klaviri i pianina");
            TreeNode treeNode71 = new TreeNode("Harmonike");
            TreeNode treeNode72 = new TreeNode("Električne klavijature");
            TreeNode treeNode73 = new TreeNode("Instrumenti s tipkama", new TreeNode[] { treeNode70, treeNode71, treeNode72 });
            TreeNode treeNode74 = new TreeNode("Violine");
            TreeNode treeNode75 = new TreeNode("Viole");
            TreeNode treeNode76 = new TreeNode("Violončela");
            TreeNode treeNode77 = new TreeNode("Kontrabasi");
            TreeNode treeNode78 = new TreeNode("Gudaći instrumenti", new TreeNode[] { treeNode74, treeNode75, treeNode76, treeNode77 });
            TreeNode treeNode79 = new TreeNode("Saksofoni");
            TreeNode treeNode80 = new TreeNode("Flaute");
            TreeNode treeNode81 = new TreeNode("Klarineti");
            TreeNode treeNode82 = new TreeNode("Tromboni");
            TreeNode treeNode83 = new TreeNode("Puhači instrumenti", new TreeNode[] { treeNode79, treeNode80, treeNode81, treeNode82 });
            TreeNode treeNode84 = new TreeNode("Instrumenti", new TreeNode[] { treeNode69, treeNode73, treeNode78, treeNode83 });
            TreeNode treeNode85 = new TreeNode("Žice za gitare");
            TreeNode treeNode86 = new TreeNode("Koferi i torbe za gitare");
            TreeNode treeNode87 = new TreeNode("Koferi i torbe za klavijature");
            TreeNode treeNode88 = new TreeNode("Koferi i torbe za harmonike");
            TreeNode treeNode89 = new TreeNode("Razna oprema", new TreeNode[] { treeNode85, treeNode86, treeNode87, treeNode88 });
            TreeNode treeNode90 = new TreeNode("Svi proizvodi");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUser));
            label1 = new Label();
            treeView1 = new TreeView();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            Odjava = new Button();
            panel4 = new Panel();
            ProsleKupnje = new Button();
            panel3 = new Panel();
            Novcanik = new Button();
            panel2 = new Panel();
            UrediPodatke = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            Down = new PictureBox();
            Dropdown = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            iznos_novcanika = new Label();
            UkloniFilter = new Button();
            Filter = new ComboBox();
            InstrumentiPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Down).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Sienna;
            label1.Font = new Font("Magneto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 1;
            label1.Text = "Music Shop";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.AntiqueWhite;
            treeView1.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeView1.Location = new Point(21, 180);
            treeView1.Name = "treeView1";
            treeNode61.Name = "akusticne";
            treeNode61.Text = "Akustične gitare";
            treeNode62.Name = "klasicne";
            treeNode62.Text = "Klasične gitare";
            treeNode63.Name = "elektricne";
            treeNode63.Text = "Električne gitare";
            treeNode64.Name = "bas";
            treeNode64.Text = "Bas gitare";
            treeNode65.Name = "mandoline";
            treeNode65.Text = "Mandoline";
            treeNode66.Name = "banjo";
            treeNode66.Text = "Banjo";
            treeNode67.Name = "ukulele";
            treeNode67.Text = "Ukulele";
            treeNode68.Name = "ostalo_zicani";
            treeNode68.Text = "Ostali žičani instrumenti";
            treeNode69.Name = "gitare";
            treeNode69.Text = "Gitare";
            treeNode70.Name = "klaviri_pianina";
            treeNode70.Text = "Klaviri i pianina";
            treeNode71.Name = "harmonike";
            treeNode71.Text = "Harmonike";
            treeNode72.Name = "elektricne_klavijature";
            treeNode72.Text = "Električne klavijature";
            treeNode73.Name = "instrumenti_tipke";
            treeNode73.Text = "Instrumenti s tipkama";
            treeNode74.Name = "violine";
            treeNode74.Text = "Violine";
            treeNode75.Name = "viole";
            treeNode75.Text = "Viole";
            treeNode76.Name = "violoncela";
            treeNode76.Text = "Violončela";
            treeNode77.Name = "kontrabasi";
            treeNode77.Text = "Kontrabasi";
            treeNode78.Name = "gudaci";
            treeNode78.Text = "Gudaći instrumenti";
            treeNode79.Name = "saksofoni";
            treeNode79.Text = "Saksofoni";
            treeNode80.Name = "flaute";
            treeNode80.Text = "Flaute";
            treeNode81.Name = "klarineti";
            treeNode81.Text = "Klarineti";
            treeNode82.Name = "tromboni";
            treeNode82.Text = "Tromboni";
            treeNode83.Name = "puhaci";
            treeNode83.Text = "Puhači instrumenti";
            treeNode84.Name = "instrumenti";
            treeNode84.Text = "Instrumenti";
            treeNode85.Name = "zice";
            treeNode85.Text = "Žice za gitare";
            treeNode86.Name = "koferi_torbe_gitare";
            treeNode86.Text = "Koferi i torbe za gitare";
            treeNode87.Name = "koferi_torbe_klavijature";
            treeNode87.Text = "Koferi i torbe za klavijature";
            treeNode88.Name = "koferi_torbe_harmonike";
            treeNode88.Text = "Koferi i torbe za harmonike";
            treeNode89.Name = "razna_oprema";
            treeNode89.Text = "Razna oprema";
            treeNode90.Name = "SviProizvodi";
            treeNode90.Text = "Svi proizvodi";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode84, treeNode89, treeNode90 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(331, 536);
            treeView1.TabIndex = 4;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Sienna;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1201, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(Odjava);
            panel5.Location = new Point(0, 260);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 65);
            panel5.TabIndex = 4;
            // 
            // Odjava
            // 
            Odjava.FlatAppearance.BorderSize = 0;
            Odjava.FlatStyle = FlatStyle.Flat;
            Odjava.Font = new Font("Gabriola", 13.8F);
            Odjava.Location = new Point(-5, 0);
            Odjava.Name = "Odjava";
            Odjava.Size = new Size(261, 65);
            Odjava.TabIndex = 6;
            Odjava.Text = "Odjava";
            Odjava.UseVisualStyleBackColor = true;
            Odjava.Click += Odjava_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(ProsleKupnje);
            panel4.Location = new Point(0, 195);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 65);
            panel4.TabIndex = 3;
            // 
            // ProsleKupnje
            // 
            ProsleKupnje.FlatAppearance.BorderSize = 0;
            ProsleKupnje.FlatStyle = FlatStyle.Flat;
            ProsleKupnje.Font = new Font("Gabriola", 13.8F);
            ProsleKupnje.Location = new Point(-5, 0);
            ProsleKupnje.Name = "ProsleKupnje";
            ProsleKupnje.Size = new Size(261, 74);
            ProsleKupnje.TabIndex = 6;
            ProsleKupnje.Text = "Prošle kupnje";
            ProsleKupnje.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(Novcanik);
            panel3.Location = new Point(0, 130);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 65);
            panel3.TabIndex = 2;
            // 
            // Novcanik
            // 
            Novcanik.FlatAppearance.BorderSize = 0;
            Novcanik.FlatStyle = FlatStyle.Flat;
            Novcanik.Font = new Font("Gabriola", 13.8F);
            Novcanik.Location = new Point(-5, 0);
            Novcanik.Name = "Novcanik";
            Novcanik.Size = new Size(261, 73);
            Novcanik.TabIndex = 6;
            Novcanik.Text = "Dodaj iznos u novčanik";
            Novcanik.UseVisualStyleBackColor = true;
            Novcanik.Click += Novcanik_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(UrediPodatke);
            panel2.Location = new Point(0, 65);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 65);
            panel2.TabIndex = 1;
            // 
            // UrediPodatke
            // 
            UrediPodatke.FlatAppearance.BorderSize = 0;
            UrediPodatke.FlatStyle = FlatStyle.Flat;
            UrediPodatke.Font = new Font("Gabriola", 13.8F);
            UrediPodatke.Location = new Point(-5, 0);
            UrediPodatke.Name = "UrediPodatke";
            UrediPodatke.Size = new Size(261, 71);
            UrediPodatke.TabIndex = 6;
            UrediPodatke.Text = "Uređivanje korisničkih podataka";
            UrediPodatke.UseVisualStyleBackColor = true;
            UrediPodatke.Click += UrediPodatke_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(Down);
            panel1.Controls.Add(Dropdown);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Sienna;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Down
            // 
            Down.BackColor = Color.Sienna;
            Down.Image = (Image)resources.GetObject("Down.Image");
            Down.Location = new Point(220, 23);
            Down.Name = "Down";
            Down.Size = new Size(15, 15);
            Down.SizeMode = PictureBoxSizeMode.StretchImage;
            Down.TabIndex = 6;
            Down.TabStop = false;
            Down.Click += Down_Click;
            // 
            // Dropdown
            // 
            Dropdown.BackColor = Color.Sienna;
            Dropdown.FlatAppearance.BorderSize = 0;
            Dropdown.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Dropdown.Location = new Point(-5, -13);
            Dropdown.Name = "Dropdown";
            Dropdown.Size = new Size(261, 86);
            Dropdown.TabIndex = 6;
            Dropdown.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(660, 9);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.MaximumSize = new Size(250, 325);
            flowLayoutPanel1.MinimumSize = new Size(249, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(249, 60);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Sienna;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(947, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Sienna;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1135, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // iznos_novcanika
            // 
            iznos_novcanika.AutoSize = true;
            iznos_novcanika.BackColor = Color.Sienna;
            iznos_novcanika.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            iznos_novcanika.ForeColor = Color.GreenYellow;
            iznos_novcanika.Location = new Point(980, 9);
            iznos_novcanika.Margin = new Padding(0);
            iznos_novcanika.Name = "iznos_novcanika";
            iznos_novcanika.Size = new Size(0, 55);
            iznos_novcanika.TabIndex = 28;
            // 
            // UkloniFilter
            // 
            UkloniFilter.Font = new Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UkloniFilter.Location = new Point(224, 114);
            UkloniFilter.Name = "UkloniFilter";
            UkloniFilter.Size = new Size(128, 45);
            UkloniFilter.TabIndex = 35;
            UkloniFilter.Text = "Ukloni filter";
            UkloniFilter.UseVisualStyleBackColor = true;
            UkloniFilter.Click += UkloniFilter_Click_1;
            // 
            // Filter
            // 
            Filter.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Filter.FormattingEnabled = true;
            Filter.Items.AddRange(new object[] { "Po najnižoj cijeni", "Po najvišoj cijeni" });
            Filter.Location = new Point(20, 114);
            Filter.Name = "Filter";
            Filter.Size = new Size(198, 45);
            Filter.TabIndex = 34;
            Filter.Text = "Sortiraj prema cijeni";
            Filter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // InstrumentiPanel
            // 
            InstrumentiPanel.BackColor = SystemColors.Control;
            InstrumentiPanel.BackgroundImageLayout = ImageLayout.None;
            InstrumentiPanel.Location = new Point(373, 114);
            InstrumentiPanel.Name = "InstrumentiPanel";
            InstrumentiPanel.Size = new Size(799, 602);
            InstrumentiPanel.TabIndex = 33;
            InstrumentiPanel.Paint += InstrumentiPanel_Paint;
            // 
            // HomeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            ControlBox = false;
            Controls.Add(UkloniFilter);
            Controls.Add(Filter);
            Controls.Add(InstrumentiPanel);
            Controls.Add(iznos_novcanika);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(treeView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 750);
            MinimizeBox = false;
            MinimumSize = new Size(1200, 600);
            Name = "HomeUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Shop";
            Load += MusicShop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Down).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TreeView treeView1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button Odjava;
        private Panel panel4;
        private Button ProsleKupnje;
        private Panel panel3;
        private Button Novcanik;
        private Panel panel2;
        private Button UrediPodatke;
        private Panel panel1;
        private PictureBox Down;
        private Button Dropdown;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label iznos_novcanika;
        private Button UkloniFilter;
        private ComboBox Filter;
        private FlowLayoutPanel InstrumentiPanel;
    }
}
