namespace Proiect_RMI_CasaSchimbValutar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNumePrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonedaOferita = new System.Windows.Forms.ComboBox();
            this.cbMonedaDorita = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonedaOferitaVal = new System.Windows.Forms.TextBox();
            this.tbMonedaDoritaVal = new System.Windows.Forms.TextBox();
            this.tbMonedaOferitaFinal = new System.Windows.Forms.TextBox();
            this.tbMonedaDoritaFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculSchimbValutar = new System.Windows.Forms.Button();
            this.btnSalvareTranzactie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSchimbValutar = new System.Windows.Forms.Button();
            this.pnGraficCursValutar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLCursValutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEASBINARYFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eXPORTPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.NumePrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oferta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cererea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStriplvTranzactii = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereTranzactieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPrintare = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.restaurareTranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripForm1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStriplvTranzactii.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumePrenume
            // 
            this.tbNumePrenume.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbNumePrenume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumePrenume.Location = new System.Drawing.Point(57, 190);
            this.tbNumePrenume.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumePrenume.Name = "tbNumePrenume";
            this.tbNumePrenume.Size = new System.Drawing.Size(476, 26);
            this.tbNumePrenume.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nipera", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label1.Location = new System.Drawing.Point(51, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume si prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nipera", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formular Tranzactie Valutara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMonedaOferita
            // 
            this.cbMonedaOferita.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbMonedaOferita.FormattingEnabled = true;
            this.cbMonedaOferita.Location = new System.Drawing.Point(57, 378);
            this.cbMonedaOferita.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonedaOferita.Name = "cbMonedaOferita";
            this.cbMonedaOferita.Size = new System.Drawing.Size(230, 26);
            this.cbMonedaOferita.TabIndex = 3;
            // 
            // cbMonedaDorita
            // 
            this.cbMonedaDorita.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbMonedaDorita.FormattingEnabled = true;
            this.cbMonedaDorita.Location = new System.Drawing.Point(316, 376);
            this.cbMonedaDorita.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonedaDorita.Name = "cbMonedaDorita";
            this.cbMonedaDorita.Size = new System.Drawing.Size(217, 26);
            this.cbMonedaDorita.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label3.Location = new System.Drawing.Point(52, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moneda oferita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label4.Location = new System.Drawing.Point(312, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Moneda dorita";
            // 
            // tbMonedaOferitaVal
            // 
            this.tbMonedaOferitaVal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbMonedaOferitaVal.Location = new System.Drawing.Point(70, 33);
            this.tbMonedaOferitaVal.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonedaOferitaVal.Name = "tbMonedaOferitaVal";
            this.tbMonedaOferitaVal.ReadOnly = true;
            this.tbMonedaOferitaVal.Size = new System.Drawing.Size(230, 26);
            this.tbMonedaOferitaVal.TabIndex = 7;
            // 
            // tbMonedaDoritaVal
            // 
            this.tbMonedaDoritaVal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbMonedaDoritaVal.Location = new System.Drawing.Point(330, 33);
            this.tbMonedaDoritaVal.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonedaDoritaVal.Name = "tbMonedaDoritaVal";
            this.tbMonedaDoritaVal.ReadOnly = true;
            this.tbMonedaDoritaVal.Size = new System.Drawing.Size(217, 26);
            this.tbMonedaDoritaVal.TabIndex = 8;
            // 
            // tbMonedaOferitaFinal
            // 
            this.tbMonedaOferitaFinal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbMonedaOferitaFinal.Location = new System.Drawing.Point(58, 588);
            this.tbMonedaOferitaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonedaOferitaFinal.Name = "tbMonedaOferitaFinal";
            this.tbMonedaOferitaFinal.Size = new System.Drawing.Size(230, 26);
            this.tbMonedaOferitaFinal.TabIndex = 9;
            // 
            // tbMonedaDoritaFinal
            // 
            this.tbMonedaDoritaFinal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbMonedaDoritaFinal.Location = new System.Drawing.Point(318, 588);
            this.tbMonedaDoritaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonedaDoritaFinal.Name = "tbMonedaDoritaFinal";
            this.tbMonedaDoritaFinal.ReadOnly = true;
            this.tbMonedaDoritaFinal.Size = new System.Drawing.Size(217, 26);
            this.tbMonedaDoritaFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.galben;
            this.label5.Location = new System.Drawing.Point(558, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "CURS VALUTAR";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label6.Location = new System.Drawing.Point(67, 543);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "Scrieti aici cat doriti sa oferiti ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label7.Location = new System.Drawing.Point(368, 568);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cat obtineti";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculSchimbValutar
            // 
            this.btnCalculSchimbValutar.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov_inchis;
            this.btnCalculSchimbValutar.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculSchimbValutar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnCalculSchimbValutar.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov;
            this.btnCalculSchimbValutar.Location = new System.Drawing.Point(58, 626);
            this.btnCalculSchimbValutar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculSchimbValutar.Name = "btnCalculSchimbValutar";
            this.btnCalculSchimbValutar.Size = new System.Drawing.Size(232, 108);
            this.btnCalculSchimbValutar.TabIndex = 14;
            this.btnCalculSchimbValutar.Text = "Calcul schimb valutar";
            this.btnCalculSchimbValutar.UseVisualStyleBackColor = true;
            this.btnCalculSchimbValutar.Click += new System.EventHandler(this.btnCalculSchimbValutar_Click);
            // 
            // btnSalvareTranzactie
            // 
            this.btnSalvareTranzactie.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov_inchis;
            this.btnSalvareTranzactie.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvareTranzactie.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalvareTranzactie.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov;
            this.btnSalvareTranzactie.Location = new System.Drawing.Point(318, 626);
            this.btnSalvareTranzactie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvareTranzactie.Name = "btnSalvareTranzactie";
            this.btnSalvareTranzactie.Size = new System.Drawing.Size(219, 68);
            this.btnSalvareTranzactie.TabIndex = 15;
            this.btnSalvareTranzactie.Text = "Salvare Tranzactie";
            this.btnSalvareTranzactie.UseVisualStyleBackColor = true;
            this.btnSalvareTranzactie.Click += new System.EventHandler(this.btnPrintare_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.galben;
            this.panel1.Controls.Add(this.btnSchimbValutar);
            this.panel1.Controls.Add(this.tbMonedaOferitaVal);
            this.panel1.Controls.Add(this.tbMonedaDoritaVal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-12, 429);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2020, 93);
            this.panel1.TabIndex = 16;
            // 
            // btnSchimbValutar
            // 
            this.btnSchimbValutar.Font = new System.Drawing.Font("Nipera", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchimbValutar.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.galben;
            this.btnSchimbValutar.Location = new System.Drawing.Point(558, 10);
            this.btnSchimbValutar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchimbValutar.Name = "btnSchimbValutar";
            this.btnSchimbValutar.Size = new System.Drawing.Size(157, 70);
            this.btnSchimbValutar.TabIndex = 22;
            this.btnSchimbValutar.Text = "Curs Valutar";
            this.btnSchimbValutar.UseVisualStyleBackColor = true;
            this.btnSchimbValutar.Click += new System.EventHandler(this.btnSchimbValutar_Click);
            // 
            // pnGraficCursValutar
            // 
            this.pnGraficCursValutar.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov;
            this.pnGraficCursValutar.Location = new System.Drawing.Point(711, 158);
            this.pnGraficCursValutar.Margin = new System.Windows.Forms.Padding(4);
            this.pnGraficCursValutar.Name = "pnGraficCursValutar";
            this.pnGraficCursValutar.Size = new System.Drawing.Size(682, 590);
            this.pnGraficCursValutar.TabIndex = 17;
            this.pnGraficCursValutar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGraficCursValutar_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nipera", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label8.Location = new System.Drawing.Point(707, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(543, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valoare Curs Valutar fata de moneda oferita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nipera", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label9.Location = new System.Drawing.Point(51, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbAdresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresa.Location = new System.Drawing.Point(58, 288);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(476, 26);
            this.tbAdresa.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.menuStrip1.Font = new System.Drawing.Font("Nipera", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "Menu Line";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.sAVEASToolStripMenuItem});
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(45, 18);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLCursValutarToolStripMenuItem,
            this.tranzactieToolStripMenuItem,
            this.tranzactiiTextToolStripMenuItem});
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // xMLCursValutarToolStripMenuItem
            // 
            this.xMLCursValutarToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xMLCursValutarToolStripMenuItem.BackgroundImage")));
            this.xMLCursValutarToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.xMLCursValutarToolStripMenuItem.Name = "xMLCursValutarToolStripMenuItem";
            this.xMLCursValutarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.xMLCursValutarToolStripMenuItem.Text = "XML Curs Valutar";
            this.xMLCursValutarToolStripMenuItem.Click += new System.EventHandler(this.xMLCursValutarToolStripMenuItem_Click);
            // 
            // tranzactieToolStripMenuItem
            // 
            this.tranzactieToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tranzactieToolStripMenuItem.BackgroundImage")));
            this.tranzactieToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.tranzactieToolStripMenuItem.Name = "tranzactieToolStripMenuItem";
            this.tranzactieToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tranzactieToolStripMenuItem.Text = "Tranzactii Binare";
            this.tranzactieToolStripMenuItem.Click += new System.EventHandler(this.tranzactieToolStripMenuItem_Click);
            // 
            // tranzactiiTextToolStripMenuItem
            // 
            this.tranzactiiTextToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.tranzactiiTextToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.tranzactiiTextToolStripMenuItem.Name = "tranzactiiTextToolStripMenuItem";
            this.tranzactiiTextToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tranzactiiTextToolStripMenuItem.Text = "Tranzactii Text";
            this.tranzactiiTextToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiTextToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickSaveAsPDFToolStripMenuItem,
            this.sAVEASBINARYFILEToolStripMenuItem});
            this.sAVEToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // quickSaveAsPDFToolStripMenuItem
            // 
            this.quickSaveAsPDFToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickSaveAsPDFToolStripMenuItem.BackgroundImage")));
            this.quickSaveAsPDFToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.quickSaveAsPDFToolStripMenuItem.Name = "quickSaveAsPDFToolStripMenuItem";
            this.quickSaveAsPDFToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.quickSaveAsPDFToolStripMenuItem.Text = "Quick Save as PDF";
            this.quickSaveAsPDFToolStripMenuItem.Click += new System.EventHandler(this.quickSaveAsPDFToolStripMenuItem_Click);
            // 
            // sAVEASBINARYFILEToolStripMenuItem
            // 
            this.sAVEASBINARYFILEToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sAVEASBINARYFILEToolStripMenuItem.BackgroundImage")));
            this.sAVEASBINARYFILEToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.sAVEASBINARYFILEToolStripMenuItem.Name = "sAVEASBINARYFILEToolStripMenuItem";
            this.sAVEASBINARYFILEToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sAVEASBINARYFILEToolStripMenuItem.Text = "SAVE AS BINARY FILE";
            this.sAVEASBINARYFILEToolStripMenuItem.Click += new System.EventHandler(this.sAVEASBINARYFILEToolStripMenuItem_Click);
            // 
            // sAVEASToolStripMenuItem
            // 
            this.sAVEASToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.sAVEASToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.sAVEASToolStripMenuItem.Name = "sAVEASToolStripMenuItem";
            this.sAVEASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sAVEASToolStripMenuItem.Text = "SAVE AS";
            this.sAVEASToolStripMenuItem.Click += new System.EventHandler(this.sAVEASToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru_inchis;
            this.hELPToolStripMenuItem.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(52, 18);
            this.hELPToolStripMenuItem.Text = "HELP";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // contextMenuStripForm1
            // 
            this.contextMenuStripForm1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contextMenuStripForm1.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.galben;
            this.contextMenuStripForm1.Font = new System.Drawing.Font("Nipera", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXPORTPDFToolStripMenuItem,
            this.hELPToolStripMenuItem1,
            this.eXITAPPToolStripMenuItem});
            this.contextMenuStripForm1.Name = "contextMenuStrip1";
            this.contextMenuStripForm1.Size = new System.Drawing.Size(154, 70);
            // 
            // eXPORTPDFToolStripMenuItem
            // 
            this.eXPORTPDFToolStripMenuItem.Name = "eXPORTPDFToolStripMenuItem";
            this.eXPORTPDFToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eXPORTPDFToolStripMenuItem.Text = "EXPORT PDF";
            this.eXPORTPDFToolStripMenuItem.Click += new System.EventHandler(this.eXPORTPDFToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem1
            // 
            this.hELPToolStripMenuItem1.Name = "hELPToolStripMenuItem1";
            this.hELPToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.hELPToolStripMenuItem1.Text = "HELP";
            this.hELPToolStripMenuItem1.Click += new System.EventHandler(this.hELPToolStripMenuItem1_Click);
            // 
            // eXITAPPToolStripMenuItem
            // 
            this.eXITAPPToolStripMenuItem.Name = "eXITAPPToolStripMenuItem";
            this.eXITAPPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eXITAPPToolStripMenuItem.Text = "EXIT APP";
            this.eXITAPPToolStripMenuItem.Click += new System.EventHandler(this.eXITAPPToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov;
            this.panel3.Controls.Add(this.lvTranzactii);
            this.panel3.Location = new System.Drawing.Point(1401, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 590);
            this.panel3.TabIndex = 18;
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lvTranzactii.CheckBoxes = true;
            this.lvTranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumePrenume,
            this.Adresa,
            this.Oferta,
            this.Cantitate1,
            this.Cererea,
            this.Cantitate2});
            this.lvTranzactii.ContextMenuStrip = this.contextMenuStriplvTranzactii;
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(3, 3);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(504, 584);
            this.lvTranzactii.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvTranzactii.TabIndex = 0;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactii.View = System.Windows.Forms.View.Details;
            // 
            // NumePrenume
            // 
            this.NumePrenume.Text = "Nume si Prenume";
            this.NumePrenume.Width = 137;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 84;
            // 
            // Oferta
            // 
            this.Oferta.Text = "Oferta";
            this.Oferta.Width = 58;
            // 
            // Cantitate1
            // 
            this.Cantitate1.Text = "Cantitate";
            this.Cantitate1.Width = 78;
            // 
            // Cererea
            // 
            this.Cererea.Text = "Cererea";
            this.Cererea.Width = 72;
            // 
            // Cantitate2
            // 
            this.Cantitate2.Text = "Cantitate";
            this.Cantitate2.Width = 86;
            // 
            // contextMenuStriplvTranzactii
            // 
            this.contextMenuStriplvTranzactii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereTranzactieToolStripMenuItem,
            this.restaurareTranzactiiToolStripMenuItem,
            this.hELPToolStripMenuItem2});
            this.contextMenuStriplvTranzactii.Name = "contextMenuStriplvTranzactii";
            this.contextMenuStriplvTranzactii.Size = new System.Drawing.Size(294, 92);
            // 
            // stergereTranzactieToolStripMenuItem
            // 
            this.stergereTranzactieToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.stergereTranzactieToolStripMenuItem.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergereTranzactieToolStripMenuItem.Name = "stergereTranzactieToolStripMenuItem";
            this.stergereTranzactieToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.stergereTranzactieToolStripMenuItem.Text = "Stergere tranzactie";
            this.stergereTranzactieToolStripMenuItem.Click += new System.EventHandler(this.stergereTranzactieToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Image = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.label10.Location = new System.Drawing.Point(1401, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Lista Tranzactii Efectuate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker1.Location = new System.Drawing.Point(1708, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnPrintare
            // 
            this.btnPrintare.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPrintare.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.mov;
            this.btnPrintare.Font = new System.Drawing.Font("Nipera", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintare.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPrintare.Location = new System.Drawing.Point(1401, 752);
            this.btnPrintare.Name = "btnPrintare";
            this.btnPrintare.Size = new System.Drawing.Size(178, 70);
            this.btnPrintare.TabIndex = 24;
            this.btnPrintare.Text = "Printare";
            this.btnPrintare.UseVisualStyleBackColor = false;
            this.btnPrintare.Click += new System.EventHandler(this.btnPrintare_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // restaurareTranzactiiToolStripMenuItem
            // 
            this.restaurareTranzactiiToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.restaurareTranzactiiToolStripMenuItem.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurareTranzactiiToolStripMenuItem.Name = "restaurareTranzactiiToolStripMenuItem";
            this.restaurareTranzactiiToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.restaurareTranzactiiToolStripMenuItem.Text = "Restaurare Tranzactii";
            this.restaurareTranzactiiToolStripMenuItem.Click += new System.EventHandler(this.restaurareTranzactiiToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem2
            // 
            this.hELPToolStripMenuItem2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.hELPToolStripMenuItem2.Font = new System.Drawing.Font("Nipera", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hELPToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hELPToolStripMenuItem2.Name = "hELPToolStripMenuItem2";
            this.hELPToolStripMenuItem2.Size = new System.Drawing.Size(293, 22);
            this.hELPToolStripMenuItem2.Text = "HELP";
            this.hELPToolStripMenuItem2.Click += new System.EventHandler(this.hELPToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_RMI_CasaSchimbValutar.Properties.Resources.albastru;
            this.ClientSize = new System.Drawing.Size(1924, 908);
            this.ContextMenuStrip = this.contextMenuStripForm1;
            this.Controls.Add(this.btnPrintare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnGraficCursValutar);
            this.Controls.Add(this.btnSalvareTranzactie);
            this.Controls.Add(this.btnCalculSchimbValutar);
            this.Controls.Add(this.tbMonedaDoritaFinal);
            this.Controls.Add(this.tbMonedaOferitaFinal);
            this.Controls.Add(this.cbMonedaDorita);
            this.Controls.Add(this.cbMonedaOferita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumePrenume);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Casa de schimb valutar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripForm1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStriplvTranzactii.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumePrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonedaOferita;
        private System.Windows.Forms.ComboBox cbMonedaDorita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMonedaOferitaVal;
        private System.Windows.Forms.TextBox tbMonedaDoritaVal;
        private System.Windows.Forms.TextBox tbMonedaOferitaFinal;
        private System.Windows.Forms.TextBox tbMonedaDoritaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculSchimbValutar;
        private System.Windows.Forms.Button btnSalvareTranzactie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnGraficCursValutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLCursValutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSaveAsPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEASBINARYFILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEASToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForm1;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.Button btnSchimbValutar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.ColumnHeader NumePrenume;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Oferta;
        private System.Windows.Forms.ColumnHeader Cantitate1;
        private System.Windows.Forms.ColumnHeader Cererea;
        private System.Windows.Forms.ColumnHeader Cantitate2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1=new System.Windows.Forms.SaveFileDialog();
        private System.Windows.Forms.OpenFileDialog openFileDialog1=new System.Windows.Forms.OpenFileDialog();
        private System.Windows.Forms.ToolStripMenuItem tranzactiiTextToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrintare;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem eXPORTPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eXITAPPToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStriplvTranzactii;
        private System.Windows.Forms.ToolStripMenuItem stergereTranzactieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareTranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem2;
    }
}

