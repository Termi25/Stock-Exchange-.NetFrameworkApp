using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
//Casa de schimb valutar -  clase: Valute Tranzactii CursuriValutare
namespace Proiect_RMI_CasaSchimbValutar
{
    public partial class Form1 : Form
    {
        private Tranzactie t = new Tranzactie();
        private List<Tranzactie> ListaTranzactii = new List<Tranzactie>();
        private CursValutar cv = new CursValutar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String URLString = "https://www.bnr.ro/nbrfxrates.xml";
            //XmlTextReader reader = new XmlTextReader(URLString);
            //int id = 0;
            //incarcare fisier XML default
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"bnr.xml");
                XmlNodeList xnList = xmlDoc.ChildNodes;

                //initializare nume si data curs valutar
                XmlNodeList xnNumeData = xnList[0].ChildNodes;
                string nume = xnNumeData[0]["Publisher"].InnerText;
                string data = xnNumeData[0]["PublishingDate"].InnerText;
                cv.apelGenCod();
                cv.Nume = nume;
                cv.Data = data;


                XmlNodeList xnCurs = (xnNumeData[1].ChildNodes)[2].ChildNodes;
                int i = 0, n = xnCurs.Count+1;
                float[] vector_cursValutar = new float[n];
                Valuta[] vector_numeValuta = new Valuta[n];
                vector_numeValuta[0] = new Valuta("RON");
                vector_cursValutar[0] = 1.0f;
                i++;
                foreach (XmlNode xn in xnCurs)
                {
                    string numeVal = xn.Attributes["currency"].Value;
                    vector_numeValuta[i] = new Valuta(numeVal);
                    float nr = (float)Convert.ToDouble(xn.InnerText,CultureInfo.InvariantCulture.NumberFormat);
                    vector_cursValutar[i] = nr;
                    i++;
                }
                cv.setVector_CursValutar(vector_cursValutar, n);
                cv.setVector_NumeValuta(vector_numeValuta, n);
            }
            catch
            {
                string mesaj_eroare = "A esuat incarcarea fisierului XML. Va rog sa verificati fisierul.";
                MessageBox.Show(mesaj_eroare);
            }
            string mesaj = "A fost incarcat cursul valutar default.";
            MessageBox.Show(mesaj);

            //incarcare comboBox
            foreach (Valuta val in cv.Vector_NumeValuta)
            {
                cbMonedaDorita.Items.Add(val.Denumire_scurta);
                cbMonedaOferita.Items.Add(val.Denumire_scurta);
            }
        }

        private void evolutieCursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculSchimbValutar_Click(object sender, EventArgs e)
        {
            string mesaj = "Nu ati incarcat un curs valutar.";
            if (cv.Cod == 0)
            {
                MessageBox.Show(mesaj);
            }
            try
            {
                try
                {
                    string nume = tbNumePrenume.Text;
                    string adresa = tbAdresa.Text;
                    t.Nume = nume;
                    t.Adresa = adresa;
                }
                catch
                {
                    mesaj = "Nu ati introdus corect numele si adresa.";
                    MessageBox.Show(mesaj);
                }
                int poz1 = -1, poz2 = -1;
                for (int i = 0; i < cv.Dimensiune; i++)
                {
                    if (cv.Vector_NumeValuta[i].Denumire_scurta.Equals(cbMonedaOferita.GetItemText(cbMonedaOferita.SelectedItem)))
                    {
                        poz1 = i;
                    }
                    if (cv.Vector_NumeValuta[i].Denumire_scurta.Equals(cbMonedaDorita.GetItemText(cbMonedaDorita.SelectedItem)))
                    {
                        poz2 = i;
                    }
                }
                if (poz1 == -1 || poz2 == -1)
                {
                    mesaj = "Valorile alese nu se regasesc in fisierul incarcat.";
                    MessageBox.Show(mesaj);
                }
                else
                {
                    tbMonedaOferitaVal.Text = "1";
                    tbMonedaDoritaVal.Text = Convert.ToString((float)(cv.Vector_CursValutar[poz2] / cv.Vector_CursValutar[poz1]));
                    Valuta[] de_transmis = new Valuta[2];
                    de_transmis[0] = new Valuta(cv.Vector_NumeValuta[poz1].Id, cv.Vector_NumeValuta[poz1].Denumire_scurta);
                    de_transmis[1] = new Valuta(cv.Vector_NumeValuta[poz2].Id, cv.Vector_NumeValuta[poz2].Denumire_scurta);
                    float[] de_transmis_cursValutar = new float[2];
                    de_transmis_cursValutar[0] = cv.Vector_CursValutar[poz1];
                    de_transmis_cursValutar[1] = cv.Vector_CursValutar[poz2];
                    t.CursValutarCurent = new CursValutar(cv.Cod, de_transmis_cursValutar, de_transmis, 2, cv.Data, cv.Nume);
                }
                t.setCantitatePrimaMoneda((float)Convert.ToDouble(tbMonedaOferitaFinal.Text));
                t.calculSchimbValutarCantitate();
                tbMonedaDoritaFinal.Text = Convert.ToString(t.ListaSchimbCantitate[1]);
            }
            catch
            {
                mesaj = "Nu ati selectat monedele de schimb pentru care sa se calculeze schimbul valutar.";
                MessageBox.Show(mesaj);
            } 
        }

        private void btnSchimbValutar_Click(object sender, EventArgs e)
        {
            string mesaj = "Nu ati incarcat un curs valutar.";
            if (cv.Cod == 0)
            {
                MessageBox.Show(mesaj);
            }

            try
            {
                int poz1 = -1, poz2 = -1;
                for(int i = 0; i < cv.Dimensiune; i++)
                {
                    if (cv.Vector_NumeValuta[i].Denumire_scurta.Equals(cbMonedaOferita.GetItemText(cbMonedaOferita.SelectedItem)))
                    {
                        poz1 = i;
                    }
                    if (cv.Vector_NumeValuta[i].Denumire_scurta.Equals(cbMonedaDorita.GetItemText(cbMonedaDorita.SelectedItem)))
                    {
                        poz2 = i;
                    }
                }
                if(poz1==-1 || poz2 == -1)
                {
                    mesaj = "Valorile alese nu se regasesc in fisierul incarcat.";
                    MessageBox.Show(mesaj);
                }
                else
                {
                    tbMonedaOferitaVal.Text = "1";
                    tbMonedaDoritaVal.Text = Convert.ToString((float)(cv.Vector_CursValutar[poz2] / cv.Vector_CursValutar[poz1]));
                    Valuta[] de_transmis = new Valuta[2];
                    de_transmis[0] = new Valuta(cv.Vector_NumeValuta[poz1].Id, cv.Vector_NumeValuta[poz1].Denumire_scurta);
                    de_transmis[1] = new Valuta(cv.Vector_NumeValuta[poz2].Id, cv.Vector_NumeValuta[poz2].Denumire_scurta);
                    float[] de_transmis_cursValutar= new float[2];
                    de_transmis_cursValutar[0] = cv.Vector_CursValutar[poz1];
                    de_transmis_cursValutar[1] = cv.Vector_CursValutar[poz2];
                    t.CursValutarCurent=new CursValutar(cv.Cod,de_transmis_cursValutar,de_transmis,2,cv.Data,cv.Nume);
                }
            }
            catch
            {
                mesaj = "Nu ati selectat monedele de schimb pentru care sa se calculeze schimbul valutar.";
                MessageBox.Show(mesaj);
            }
            
        }

        private void xMLCursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"bnr.xml");
                XmlNodeList xnList = xmlDoc.ChildNodes;

                //initializare nume si data curs valutar
                XmlNodeList xnNumeData = xnList[0].ChildNodes;
                string nume = xnNumeData[0]["Publisher"].InnerText;
                string data = xnNumeData[0]["PublishingDate"].InnerText;
                cv.apelGenCod();
                cv.Nume = nume;
                cv.Data = data;



                XmlNodeList xnCurs = (xnNumeData[1].ChildNodes)[2].ChildNodes;
                int i = 0, n = xnCurs.Count+1;
                float[] vector_cursValutar = new float[n];
                Valuta[] vector_numeValuta = new Valuta[n];
                vector_numeValuta[0] = new Valuta("RON");
                vector_cursValutar[0] = 1.0f;
                i++;
                foreach (XmlNode xn in xnCurs)
                {
                    string numeVal = xn.Attributes["currency"].Value;
                    vector_numeValuta[i] = new Valuta(numeVal);
                    float nr = (float)Convert.ToDouble(xn.InnerText, CultureInfo.InvariantCulture.NumberFormat);
                    vector_cursValutar[i] = nr;
                    i++;
                }
                cv.setVector_CursValutar(vector_cursValutar, n);
                cv.setVector_NumeValuta(vector_numeValuta, n);
            }
            catch
            {
                string mesaj = "A esuat incarcarea fisierului XML. Va rog sa verificati fisierul.";
                MessageBox.Show(mesaj);
            }
        }
    }
}
