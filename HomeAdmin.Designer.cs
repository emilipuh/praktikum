namespace MusicShop
{
    partial class HomeAdmin
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
            TreeNode treeNode31 = new TreeNode("Akustične gitare");
            TreeNode treeNode32 = new TreeNode("Klasične gitare");
            TreeNode treeNode33 = new TreeNode("Električne gitare");
            TreeNode treeNode34 = new TreeNode("Bas gitare");
            TreeNode treeNode35 = new TreeNode("Mandoline");
            TreeNode treeNode36 = new TreeNode("Banjo");
            TreeNode treeNode37 = new TreeNode("Ukulele");
            TreeNode treeNode38 = new TreeNode("Ostali žičani instrumenti", new TreeNode[] { treeNode35, treeNode36, treeNode37 });
            TreeNode treeNode39 = new TreeNode("Gitare", new TreeNode[] { treeNode31, treeNode32, treeNode33, treeNode34, treeNode38 });
            TreeNode treeNode40 = new TreeNode("Klaviri i pianina");
            TreeNode treeNode41 = new TreeNode("Harmonike");
            TreeNode treeNode42 = new TreeNode("Električne klavijature");
            TreeNode treeNode43 = new TreeNode("Instrumenti s tipkama", new TreeNode[] { treeNode40, treeNode41, treeNode42 });
            TreeNode treeNode44 = new TreeNode("Violine");
            TreeNode treeNode45 = new TreeNode("Viole");
            TreeNode treeNode46 = new TreeNode("Violončela");
            TreeNode treeNode47 = new TreeNode("Kontrabasi");
            TreeNode treeNode48 = new TreeNode("Gudaći instrumenti", new TreeNode[] { treeNode44, treeNode45, treeNode46, treeNode47 });
            TreeNode treeNode49 = new TreeNode("Saksofoni");
            TreeNode treeNode50 = new TreeNode("Flaute");
            TreeNode treeNode51 = new TreeNode("Klarineti");
            TreeNode treeNode52 = new TreeNode("Tromboni");
            TreeNode treeNode53 = new TreeNode("Puhači instrumenti", new TreeNode[] { treeNode49, treeNode50, treeNode51, treeNode52 });
            TreeNode treeNode54 = new TreeNode("Instrumenti", new TreeNode[] { treeNode39, treeNode43, treeNode48, treeNode53 });
            TreeNode treeNode55 = new TreeNode("Žice za gitare");
            TreeNode treeNode56 = new TreeNode("Koferi i torbe za gitare");
            TreeNode treeNode57 = new TreeNode("Koferi i torbe za klavijature");
            TreeNode treeNode58 = new TreeNode("Koferi i torbe za harmonike");
            TreeNode treeNode59 = new TreeNode("Razna oprema", new TreeNode[] { treeNode55, treeNode56, treeNode57, treeNode58 });
            TreeNode treeNode60 = new TreeNode("Svi proizvodi");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            treeView1 = new TreeView();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            Kosarica = new PictureBox();
            pictureBox1 = new PictureBox();
            Down = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            TrenutniKorisnik = new Button();
            panel2 = new Panel();
            UrediPodatke = new Button();
            panel3 = new Panel();
            Novcanik = new Button();
            panel4 = new Panel();
            ProsleKupnje = new Button();
            panel5 = new Panel();
            Proizvodi = new Button();
            panel6 = new Panel();
            Korisnici = new Button();
            panel7 = new Panel();
            Odjava = new Button();
            iznos_novcanika = new Label();
            InstrumentiPanel = new FlowLayoutPanel();
            FilterComboBox = new ComboBox();
            UkloniFilter = new Button();
            StavkeKosarice = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kosarica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Down).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.AntiqueWhite;
            treeView1.Font = new Font("Gabriola", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeView1.Location = new Point(20, 180);
            treeView1.Name = "treeView1";
            treeNode31.Name = "akusticne";
            treeNode31.Text = "Akustične gitare";
            treeNode32.Name = "klasicne";
            treeNode32.Text = "Klasične gitare";
            treeNode33.Name = "elektricne";
            treeNode33.Text = "Električne gitare";
            treeNode34.Name = "bas";
            treeNode34.Text = "Bas gitare";
            treeNode35.Name = "mandoline";
            treeNode35.Text = "Mandoline";
            treeNode36.Name = "banjo";
            treeNode36.Text = "Banjo";
            treeNode37.Name = "ukulele";
            treeNode37.Text = "Ukulele";
            treeNode38.Name = "ostalo_zicani";
            treeNode38.Text = "Ostali žičani instrumenti";
            treeNode39.Name = "gitare";
            treeNode39.Text = "Gitare";
            treeNode40.Name = "klaviri_pianina";
            treeNode40.Text = "Klaviri i pianina";
            treeNode41.Name = "harmonike";
            treeNode41.Text = "Harmonike";
            treeNode42.Name = "elektricne_klavijature";
            treeNode42.Text = "Električne klavijature";
            treeNode43.Name = "instrumenti_tipke";
            treeNode43.Text = "Instrumenti s tipkama";
            treeNode44.Name = "violine";
            treeNode44.Text = "Violine";
            treeNode45.Name = "viole";
            treeNode45.Text = "Viole";
            treeNode46.Name = "violoncela";
            treeNode46.Text = "Violončela";
            treeNode47.Name = "kontrabasi";
            treeNode47.Text = "Kontrabasi";
            treeNode48.Name = "gudaci";
            treeNode48.Text = "Gudaći instrumenti";
            treeNode49.Name = "saksofoni";
            treeNode49.Text = "Saksofoni";
            treeNode50.Name = "flaute";
            treeNode50.Text = "Flaute";
            treeNode51.Name = "klarineti";
            treeNode51.Text = "Klarineti";
            treeNode52.Name = "tromboni";
            treeNode52.Text = "Tromboni";
            treeNode53.Name = "puhaci";
            treeNode53.Text = "Puhači instrumenti";
            treeNode54.Name = "instrumenti";
            treeNode54.Text = "Instrumenti";
            treeNode55.Name = "zice";
            treeNode55.Text = "Žice za gitare";
            treeNode56.Name = "koferi_torbe_gitare";
            treeNode56.Text = "Koferi i torbe za gitare";
            treeNode57.Name = "koferi_torbe_klavijature";
            treeNode57.Text = "Koferi i torbe za klavijature";
            treeNode58.Name = "koferi_torbe_harmonike";
            treeNode58.Text = "Koferi i torbe za harmonike";
            treeNode59.Name = "razna_oprema";
            treeNode59.Text = "Razna oprema";
            treeNode60.Name = "sve";
            treeNode60.Text = "Svi proizvodi";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode54, treeNode59, treeNode60 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(332, 536);
            treeView1.TabIndex = 20;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Sienna;
            label2.Font = new Font("Magneto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(243, 41);
            label2.TabIndex = 18;
            label2.Text = "Music Shop";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Sienna;
            pictureBox2.Location = new Point(-2, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1202, 78);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Kosarica
            // 
            Kosarica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Kosarica.BackColor = Color.Sienna;
            Kosarica.Image = (Image)resources.GetObject("Kosarica.Image");
            Kosarica.Location = new Point(1127, 23);
            Kosarica.Name = "Kosarica";
            Kosarica.Size = new Size(30, 30);
            Kosarica.SizeMode = PictureBoxSizeMode.StretchImage;
            Kosarica.TabIndex = 24;
            Kosarica.TabStop = false;
            Kosarica.Click += Kosarica_Click;
            Kosarica.DoubleClick += Kosarica_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Sienna;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(972, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Down
            // 
            Down.BackColor = Color.Sienna;
            Down.Image = (Image)resources.GetObject("Down.Image");
            Down.Location = new Point(242, 25);
            Down.Name = "Down";
            Down.Size = new Size(15, 15);
            Down.SizeMode = PictureBoxSizeMode.StretchImage;
            Down.TabIndex = 25;
            Down.TabStop = false;
            Down.Click += Down_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Location = new Point(623, 9);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.MaximumSize = new Size(260, 455);
            flowLayoutPanel1.MinimumSize = new Size(260, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(260, 60);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(Down);
            panel1.Controls.Add(TrenutniKorisnik);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Sienna;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // TrenutniKorisnik
            // 
            TrenutniKorisnik.BackColor = Color.Sienna;
            TrenutniKorisnik.FlatAppearance.BorderSize = 0;
            TrenutniKorisnik.Font = new Font("Gabriola", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TrenutniKorisnik.Location = new Point(-5, -12);
            TrenutniKorisnik.Name = "TrenutniKorisnik";
            TrenutniKorisnik.Size = new Size(280, 85);
            TrenutniKorisnik.TabIndex = 27;
            TrenutniKorisnik.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(UrediPodatke);
            panel2.Location = new Point(0, 65);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 65);
            panel2.TabIndex = 1;
            // 
            // UrediPodatke
            // 
            UrediPodatke.FlatAppearance.BorderSize = 0;
            UrediPodatke.Font = new Font("Gabriola", 13.8F);
            UrediPodatke.Location = new Point(-10, -8);
            UrediPodatke.Name = "UrediPodatke";
            UrediPodatke.Size = new Size(280, 81);
            UrediPodatke.TabIndex = 27;
            UrediPodatke.Text = "Uređivanje korisničkih podataka";
            UrediPodatke.UseVisualStyleBackColor = true;
            UrediPodatke.Click += UrediPodatke_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Novcanik);
            panel3.Location = new Point(0, 130);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 65);
            panel3.TabIndex = 2;
            // 
            // Novcanik
            // 
            Novcanik.FlatAppearance.BorderSize = 0;
            Novcanik.Font = new Font("Gabriola", 13.8F);
            Novcanik.Location = new Point(-10, -5);
            Novcanik.Name = "Novcanik";
            Novcanik.Size = new Size(280, 76);
            Novcanik.TabIndex = 27;
            Novcanik.Text = "Dodaj iznos u novčanik";
            Novcanik.UseVisualStyleBackColor = true;
            Novcanik.Click += Novcanik_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ProsleKupnje);
            panel4.Location = new Point(0, 195);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 65);
            panel4.TabIndex = 3;
            // 
            // ProsleKupnje
            // 
            ProsleKupnje.FlatAppearance.BorderSize = 0;
            ProsleKupnje.Font = new Font("Gabriola", 13.8F);
            ProsleKupnje.Location = new Point(-10, -8);
            ProsleKupnje.Name = "ProsleKupnje";
            ProsleKupnje.Size = new Size(280, 82);
            ProsleKupnje.TabIndex = 27;
            ProsleKupnje.Text = "Prošle kupnje";
            ProsleKupnje.UseVisualStyleBackColor = true;
            ProsleKupnje.Click += ProsleKupnje_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(Proizvodi);
            panel5.Location = new Point(0, 260);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 65);
            panel5.TabIndex = 4;
            // 
            // Proizvodi
            // 
            Proizvodi.FlatAppearance.BorderSize = 0;
            Proizvodi.Font = new Font("Gabriola", 13.8F);
            Proizvodi.Location = new Point(-10, -8);
            Proizvodi.Name = "Proizvodi";
            Proizvodi.Size = new Size(280, 82);
            Proizvodi.TabIndex = 27;
            Proizvodi.Text = "Pregled proizvoda";
            Proizvodi.UseVisualStyleBackColor = true;
            Proizvodi.Click += Proizvodi_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(Korisnici);
            panel6.Location = new Point(0, 325);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(260, 65);
            panel6.TabIndex = 5;
            // 
            // Korisnici
            // 
            Korisnici.FlatAppearance.BorderSize = 0;
            Korisnici.Font = new Font("Gabriola", 13.8F);
            Korisnici.Location = new Point(-10, -10);
            Korisnici.Name = "Korisnici";
            Korisnici.Size = new Size(280, 80);
            Korisnici.TabIndex = 27;
            Korisnici.Text = "Korisnici";
            Korisnici.UseVisualStyleBackColor = true;
            Korisnici.Click += Korisnici_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(Odjava);
            panel7.Location = new Point(0, 390);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(260, 65);
            panel7.TabIndex = 6;
            // 
            // Odjava
            // 
            Odjava.FlatAppearance.BorderSize = 0;
            Odjava.Font = new Font("Gabriola", 13.8F);
            Odjava.Location = new Point(-10, -8);
            Odjava.Name = "Odjava";
            Odjava.Size = new Size(280, 79);
            Odjava.TabIndex = 27;
            Odjava.Text = "Odjava";
            Odjava.UseVisualStyleBackColor = true;
            Odjava.Click += Odjava_Click;
            // 
            // iznos_novcanika
            // 
            iznos_novcanika.AutoSize = true;
            iznos_novcanika.BackColor = Color.Sienna;
            iznos_novcanika.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            iznos_novcanika.ForeColor = Color.GreenYellow;
            iznos_novcanika.Location = new Point(1018, 9);
            iznos_novcanika.Margin = new Padding(0);
            iznos_novcanika.Name = "iznos_novcanika";
            iznos_novcanika.Size = new Size(0, 55);
            iznos_novcanika.TabIndex = 27;
            // 
            // InstrumentiPanel
            // 
            InstrumentiPanel.BackColor = SystemColors.Control;
            InstrumentiPanel.BackgroundImageLayout = ImageLayout.None;
            InstrumentiPanel.Location = new Point(373, 114);
            InstrumentiPanel.Name = "InstrumentiPanel";
            InstrumentiPanel.Size = new Size(799, 602);
            InstrumentiPanel.TabIndex = 30;
            // 
            // FilterComboBox
            // 
            FilterComboBox.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "Po najnižoj cijeni", "Po najvišoj cijeni" });
            FilterComboBox.Location = new Point(20, 114);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(198, 45);
            FilterComboBox.TabIndex = 31;
            FilterComboBox.Text = "Sortiraj prema cijeni";
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // UkloniFilter
            // 
            UkloniFilter.Font = new Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UkloniFilter.Location = new Point(224, 114);
            UkloniFilter.Name = "UkloniFilter";
            UkloniFilter.Size = new Size(128, 45);
            UkloniFilter.TabIndex = 32;
            UkloniFilter.Text = "Ukloni filter";
            UkloniFilter.UseVisualStyleBackColor = true;
            UkloniFilter.Click += UkloniFilter_Click;
            // 
            // StavkeKosarice
            // 
            StavkeKosarice.BackColor = Color.Bisque;
            StavkeKosarice.FlowDirection = FlowDirection.RightToLeft;
            StavkeKosarice.Location = new Point(891, 74);
            StavkeKosarice.Margin = new Padding(0);
            StavkeKosarice.MaximumSize = new Size(300, 400);
            StavkeKosarice.Name = "StavkeKosarice";
            StavkeKosarice.Size = new Size(300, 400);
            StavkeKosarice.TabIndex = 0;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(StavkeKosarice);
            Controls.Add(Kosarica);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(UkloniFilter);
            Controls.Add(FilterComboBox);
            Controls.Add(InstrumentiPanel);
            Controls.Add(iznos_novcanika);
            Controls.Add(pictureBox1);
            Controls.Add(treeView1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 750);
            MinimumSize = new Size(1200, 600);
            Name = "HomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomeAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kosarica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Down).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox Kosarica;
        private PictureBox pictureBox1;
        private PictureBox Down;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button TrenutniKorisnik;
        private Panel panel2;
        private Button UrediPodatke;
        private Panel panel3;
        private Button Novcanik;
        private Panel panel4;
        private Button ProsleKupnje;
        private Panel panel5;
        private Button Proizvodi;
        private Panel panel6;
        private Button Korisnici;
        private Panel panel7;
        private Button Odjava;
        private PictureBox pictureBox5;
        private Label iznos_novcanika;
        private FlowLayoutPanel InstrumentiPanel;
        private ComboBox FilterComboBox;
        private Button UkloniFilter;
        private FlowLayoutPanel StavkeKosarice;
    }
}