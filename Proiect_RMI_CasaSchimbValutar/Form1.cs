using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
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
            initializareXML();
            MessageBox.Show("A fost incarcat cursul valutar default.");
            restaurareBinara();

            //incarcare comboBox
            foreach (Valuta val in cv.Vector_NumeValuta)
            {
                cbMonedaDorita.Items.Add(val.Denumire_scurta);
                cbMonedaOferita.Items.Add(val.Denumire_scurta);
            }
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            salvareBinara();
        }

        private void initializareXML()
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
                int i = 0, n = xnCurs.Count + 1;
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
                MessageBox.Show("A esuat incarcarea fisierului XML. Va rog sa verificati fisierul.");
            }
        }

        private void SchimbValutar_apel()
        {
            if (cv.Cod == 0)
            {
                MessageBox.Show("Nu ati incarcat un curs valutar.");
            }
            else
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
                    MessageBox.Show("Nu ati introdus corect numele si adresa.");
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
                    MessageBox.Show("Valorile alese nu se regasesc in fisierul incarcat.");
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
            }
        }

        private void adaugareLista()
        {
            foreach(ListViewItem itm in lvTranzactii.Items)
            {
                itm.Remove();
            }
            foreach(Tranzactie tran in ListaTranzactii)
            {
                ListViewItem item = new ListViewItem(tran.Nume);
                item.SubItems.Add(tran.Adresa);
                item.SubItems.Add(tran.ToString().Split(',')[0]);
                item.SubItems.Add(tran.ListaSchimbCantitate[0].ToString());
                item.SubItems.Add(tran.ToString().Split(',')[1]);
                item.SubItems.Add(tran.ListaSchimbCantitate[1].ToString());
                lvTranzactii.Items.Add(item);
            }
        }

        private void golireFormular()
        {
            tbNumePrenume.Text = string.Empty;
            tbAdresa.Text = string.Empty;
            cbMonedaDorita.Text = string.Empty;
            cbMonedaOferita.Text = string.Empty;
            tbMonedaOferitaVal.Text = string.Empty;
            tbMonedaDoritaVal.Text = string.Empty;
            tbMonedaOferitaFinal.Text = string.Empty;
            tbMonedaDoritaFinal.Text = string.Empty;
        }

        private void salvareBinara()
        {
            FileStream fs = new FileStream("fisierulTranzactii.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ListaTranzactii);
            fs.Close();
            MessageBox.Show("S-a salvat fisierul binar cu toate tranzactiile efectuate!");
        }

        private void restaurareBinara()
        {
            try
            {
                FileStream fs = new FileStream("fisierulTranzactii.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf=new BinaryFormatter();
                ListaTranzactii.Clear();
                ListaTranzactii = (List<Tranzactie>)bf.Deserialize(fs);
                fs.Close();
                adaugareLista();
            }
            catch
            {
                MessageBox.Show("Nu exista salvari locale de tranzactii.");
            }
        }

        private void xMLCursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializareXML();
        }

        private void evolutieCursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSchimbValutar_Click(object sender, EventArgs e)
        {
            SchimbValutar_apel();
        }
        private void btnCalculSchimbValutar_Click(object sender, EventArgs e)
        {
            try
            {
                SchimbValutar_apel();
                t.setCantitatePrimaMoneda((float)Convert.ToDouble(tbMonedaOferitaFinal.Text));
                t.calculSchimbValutarCantitate();
                tbMonedaDoritaFinal.Text = Convert.ToString(t.ListaSchimbCantitate[1]);
            }
            catch
            {
                MessageBox.Show("Nu a fost oferita o suma pentru schimb.");
            }
        }

        private void btnPrintare_Click(object sender, EventArgs e)
        {
            int n = 0;
            foreach(Tranzactie tran in ListaTranzactii)
            {
                if(tran.Cod_tranzactie==t.Cod_tranzactie)
                {
                    n = 1;
                }
            }
            if(n == 0)
            {
                ListaTranzactii.Add(t);
                t=new Tranzactie();
                golireFormular();
                adaugareLista();
            }
            golireFormular();
        }

        private void sAVEASBINARYFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvareBinara();
        }

        private void tranzactieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restaurareBinara();
        }

        private void sAVEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                string mesaj = "FORMAT:Nume&Prenume,Adresa,Oferta,CantitateOferta,Cererea,CentitateCererea";
                mesaj = "";
                foreach (Tranzactie s in ListaTranzactii)
                {
                    mesaj = s.Nume + "," + s.Adresa + "," + s.ToString().Split(',')[0].ToString() + "," + s.ListaSchimbCantitate[0].ToString() + "," + s.ToString().Split(',')[1] + "," + s.ListaSchimbCantitate[1].ToString();
                    sw.WriteLine(mesaj);
                    mesaj = "";
                }
                sw.Close();
                ListaTranzactii.Clear();
            }
        }

        private void tranzactiiTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //tbStudenti.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
