using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Words;

namespace Proiect_RMI_CasaSchimbValutar
{
    public partial class Form3 : Form
    {
        private Tranzactie t ;
        private CursValutar cv ;
        private string data;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Tranzactie t, CursValutar cv, String data)
        {
            InitializeComponent();
            this.t = new Tranzactie(t);
            this.cv = new CursValutar(cv);
            this.data = data;
            initializareTextBox();
            populareTextBox();
        }

        private void initializareTextBox()
        {
            tbNumePrenume.BackColor = Color.FromArgb(17, 157, 164);
            tbNumePrenume.ForeColor = Color.FromArgb(255, 200, 87);
            tbAdresa.BackColor= Color.FromArgb(17, 157, 164);
            tbAdresa.ForeColor = Color.FromArgb(255, 200, 87);
            tbMonedaOferitaTxt.BackColor=Color.FromArgb(255, 200, 87);
            tbMonedaDoritaTxt.BackColor = Color.FromArgb(255, 200, 87);
            tbMonedaOferitaValoare.BackColor = Color.FromArgb(255, 200, 87);
            tbMonedaDoritaValoare.BackColor = Color.FromArgb(255, 200, 87);
            tbCantitateaOferita.BackColor = Color.FromArgb(255, 200,87);
            tbCantitateaDorita.BackColor = Color.FromArgb(255, 200, 87);
            tbData.BackColor = Color.FromArgb(17, 157, 164);
            tbData.ForeColor = Color.FromArgb(255, 200, 87);
        }

        private void populareTextBox()
        {
            tbNumePrenume.Text = t.Nume;
            tbAdresa.Text = t.Adresa;
            tbMonedaOferitaTxt.Text = t.CursValutarCurent.Vector_NumeValuta[0].Denumire_scurta;
            tbMonedaDoritaTxt.Text = t.CursValutarCurent.Vector_NumeValuta[1].Denumire_scurta;
            tbMonedaOferitaValoare.Text = t.CursValutarCurent.Vector_CursValutar[0].ToString();
            tbMonedaDoritaValoare.Text = t.CursValutarCurent.Vector_CursValutar[1].ToString();
            tbCantitateaOferita.Text = t.ListaSchimbCantitate[0].ToString();
            tbCantitateaDorita.Text = t.ListaSchimbCantitate[1].ToString();
            tbData.Text = data;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            string denumire = t.Nume+'_'+t.Cod_tranzactie;
            panelSalvare.CreateGraphics();
            Bitmap bitmap = new Bitmap(panelSalvare.Width, panelSalvare.Height);
            //g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            panelSalvare.DrawToBitmap(bitmap,new Rectangle(0,0,bitmap.Width,bitmap.Height));
            var doc = new Document();
            var builder = new DocumentBuilder(doc);

            builder.InsertImage(bitmap);
            //bitmap.Save(denumire + ".pdf");
            doc.Save(denumire+".pdf");
            MessageBox.Show("Tranzactie salvata drept PDF");
            this.Close();
        }

        private void panelSalvare_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
