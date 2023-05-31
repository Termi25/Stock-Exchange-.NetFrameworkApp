using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_RMI_CasaSchimbValutar
{
    public interface IRaport
    {
        float CalculeazaRaportSchimb(float[] listaCantitate,int nr);
    }
    [Serializable]
    public class Tranzactie: IRaport,IGenerareId, IDataObject
    {
        private int cod_tranzactie;// prima moneda este ce se vinde in schimbul celei de-a doua
        private float[] listaSchimbCantitate;
        private CursValutar cursValutarCurent;
        private string nume;
        private string adresa;

        public Tranzactie()
        {
            cod_tranzactie = creareId();
            listaSchimbCantitate = new float[2];
            cursValutarCurent = new CursValutar(2);
            nume = "NULL";
            adresa = "NULL";
        }

        public Tranzactie(int cod_tranzactie, float[] listaSchimbCantitate, CursValutar cursValutarCurent, string nume, string adresa)
        {
            this.cod_tranzactie = cod_tranzactie;
            listaSchimbCantitate = new float[2];
            for (int i = 0; i < 2;i++)
            {
                this.listaSchimbCantitate[i] = listaSchimbCantitate[i];
            }
            this.cursValutarCurent=new CursValutar(cursValutarCurent);
            this.nume = nume;
            this.adresa= adresa;
        }

        public Tranzactie(Tranzactie de_copiat)
        {
            this.cod_tranzactie = de_copiat.cod_tranzactie;
            listaSchimbCantitate = new float[2];
            for (int i = 0; i < 2; i++)
            {
                this.listaSchimbCantitate[i] = de_copiat.listaSchimbCantitate[i];
            }
            this.cursValutarCurent = new CursValutar(de_copiat.cursValutarCurent);
            this.nume = de_copiat.nume;
            this.adresa = de_copiat.adresa;
        }

        public void setCantitatePrimaMoneda(float q)
        {
            listaSchimbCantitate[0] = q;
        }

        public int Cod_tranzactie
        {
            get { return this.cod_tranzactie; }
            set { cod_tranzactie = value; }
        }

        public float[] ListaSchimbCantitate
        {
            get { return this.listaSchimbCantitate; }
            set { this.listaSchimbCantitate = value; }
        }

        public CursValutar CursValutarCurent
        {
            get { return this.cursValutarCurent; }
            set { this.cursValutarCurent = new CursValutar(value); }
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Adresa
        {
            get { return this.adresa; }
            set { this.adresa = value; }
        }


        public static bool operator >(Tranzactie t1, Tranzactie t2)
        {
            if(t1.cod_tranzactie > t2.cod_tranzactie)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Tranzactie t1, Tranzactie t2)
        {
            if (t1.cod_tranzactie < t2.cod_tranzactie)
            {
                return true;
            }
            return false;
        }

        public float this[int index]
        {
            get
            {
                if(index>=0 && index<2 && listaSchimbCantitate != null)
                {
                    return listaSchimbCantitate[index];
                }
                return -1;
            }
        }

        public float CalculeazaRaportSchimb(float[] listaCantitate, int nr)
        {
            if (nr == 2 && listaCantitate!=null)
            {
                return listaCantitate[0] / listaCantitate[1];
            }
            return -1;
        }

        public void calculSchimbValutarCantitate()
        {
            try
            {
                listaSchimbCantitate[1] = (cursValutarCurent.Vector_CursValutar[0] * listaSchimbCantitate[0]) / cursValutarCurent.Vector_CursValutar[1];
            }
            catch
            {
                MessageBox.Show("Nu a fost selectata o valoarea pentru cantitatea oferita de moneda.");
            }
        }

        public float calculSchimbValutar()
        {
            try
            {
                return cursValutarCurent.Vector_CursValutar[0] / cursValutarCurent.Vector_CursValutar[1];
            }
            catch
            {
                return -1.0f;
            }
        }

        public override string ToString()
        {
            return cursValutarCurent.ToString();
        }

        public int creareId()
        {
            Random rnd = new Random();
            int n = rnd.Next();
            return n;
        }

        public object GetData(string format, bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public object GetData(string format)
        {
            throw new NotImplementedException();
        }

        public object GetData(Type format)
        {
            throw new NotImplementedException();
        }

        public void SetData(string format, bool autoConvert, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(string format, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(Type format, object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(object data)
        {
            throw new NotImplementedException();
        }

        public bool GetDataPresent(string format, bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public bool GetDataPresent(string format)
        {
            throw new NotImplementedException();
        }

        public bool GetDataPresent(Type format)
        {
            throw new NotImplementedException();
        }

        public string[] GetFormats(bool autoConvert)
        {
            throw new NotImplementedException();
        }

        public string[] GetFormats()
        {
            throw new NotImplementedException();
        }
    }
}
