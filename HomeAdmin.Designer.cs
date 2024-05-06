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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            treeView1 = new TreeView();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            treeView1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            treeView1.Location = new Point(22, 110);
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
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode24, treeNode29 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(292, 511);
            treeView1.TabIndex = 20;
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
            pictureBox2.Location = new Point(-2, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1202, 78);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Sienna;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1142, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Sienna;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(982, 23);
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
            flowLayoutPanel1.Location = new Point(666, 10);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.MaximumSize = new Size(260, 455);
            flowLayoutPanel1.MinimumSize = new Size(260, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(260, 455);
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
            Proizvodi.Text = "Proizvodi";
            Proizvodi.UseVisualStyleBackColor = true;
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
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(iznos_novcanika);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
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
    }
}