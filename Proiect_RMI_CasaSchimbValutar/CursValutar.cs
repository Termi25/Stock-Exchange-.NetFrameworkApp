using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_RMI_CasaSchimbValutar
{
    [Serializable]
    internal class CursValutar : ICloneable, IComparable, IGenerareId
    {
        private int cod;
        private float[] vector_cursValutar;
        private Valuta[] vector_numeValuta;
        private int dimensiune;
        private string data;
        private string nume;

        public CursValutar()
        {
            cod = 0;
            dimensiune = 0;
            vector_cursValutar = null;
            vector_numeValuta = null;
            data = null;
            nume = null;
        }

        public CursValutar(int dimensiune)
        {
            cod = 0;
            this.dimensiune = dimensiune;
            vector_cursValutar = new float[dimensiune];
            vector_numeValuta = new Valuta[dimensiune];
            data = "NULL";
            nume = "NULL";
        }

        public CursValutar(int cod,float[] vector_cursValutar,Valuta[] vector_numeValuta,int dimensiune,string data,string nume)
        {
            this.cod = cod;
            this.dimensiune=dimensiune;
            if (dimensiune > 0 && vector_cursValutar!=null && vector_numeValuta!=null)
            {
                this.vector_cursValutar = new float[dimensiune];
                this.vector_numeValuta = new Valuta[dimensiune];
                for (int i = 0; i < dimensiune; i++)
                {
                    this.vector_cursValutar[i] = vector_cursValutar[i];
                    this.vector_numeValuta[i] = new Valuta(vector_numeValuta[i].Id, vector_numeValuta[i].Denumire_scurta);
                }
            }
            this.data = data;
            this.nume = nume;
        }

        public CursValutar(CursValutar de_copiat)
        {
            if (this.dimensiune == de_copiat.dimensiune)
            {
                for (int i = 0; i < dimensiune; i++)
                {
                    this.vector_cursValutar[i] = de_copiat.vector_cursValutar[i];
                    this.vector_numeValuta[i] = de_copiat.vector_numeValuta[i];
                }
            }
            else
            {
                this.dimensiune = de_copiat.dimensiune;
                this.vector_cursValutar = new float[dimensiune];
                vector_numeValuta = new Valuta[dimensiune];
                for (int i = 0; i < dimensiune; i++)
                {
                    this.vector_cursValutar[i] = de_copiat.vector_cursValutar[i];
                    this.vector_numeValuta[i] = de_copiat.vector_numeValuta[i];
                }
            }
            this.cod = de_copiat.cod;
            this.data = de_copiat.data;
            this.nume = de_copiat.nume;
        }

        public int Cod
        {
            get { return this.cod; }
            set { this.cod = value; }
        }

        public float[] Vector_CursValutar
        {
            get { return vector_cursValutar; }
        }

        public Valuta[] Vector_NumeValuta
        {
            get { return vector_numeValuta;}
        }

        public void setVector_CursValutar(float[] vector_cursValutar,int dimensiune) 
        {
            if (dimensiune > 0 && vector_cursValutar != null)
            {
                this.dimensiune = dimensiune;
                this.vector_cursValutar = new float[dimensiune];
                for (int i = 0; i < dimensiune; i++)
                {
                    this.vector_cursValutar[i] = vector_cursValutar[i];
                }
            }
        }

        public void setVector_NumeValuta(Valuta[] vector_numeValuta, int dimensiune)
        {
            if(dimensiune > 0&& vector_numeValuta!=null) {
                this.dimensiune = dimensiune;
                this.vector_numeValuta = new Valuta[dimensiune];
                for (int i = 0; i < dimensiune; i++)
                {
                    this.vector_numeValuta[i] = new Valuta(vector_numeValuta[i].Id, vector_numeValuta[i].Denumire_scurta);
                }
            }
        }
        public int Dimensiune
        {
            get { return dimensiune; }
            set { dimensiune = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public object Clone()
        {
            CursValutar nou = new CursValutar(this.cod,this.vector_cursValutar, this.vector_numeValuta, this.dimensiune, this.data, this.nume);
            return nou;
            //return (CursValutar)((ICloneable)this).Clone();
        }

        public int CompareTo(object obj)
        {
            CursValutar compara= obj as CursValutar;
            if(compara.cod>this.cod)
            {
                return -1;
            }
            else
                if (compara.cod < this.cod)
                {
                    return 1;
                }
                else 
                {
                return 0;
                }     
        }

        public int creareId()
        {
            Random rnd = new Random();
            int n = rnd.Next();
            return n;
        }

        public void apelGenCod()
        {
            cod= creareId();
        }

        public static CursValutar operator ++(CursValutar cv)
        {
            cv.cod+=1;
            return cv;
        }

        public float this[int index]
        {
            get
            {
                if(index>=0 && index<dimensiune && vector_cursValutar != null)
                {
                    return vector_cursValutar[index];
                }
                return -1;
            }
        }

        public override string ToString()
        {
            string mesaj = "";
            foreach(Valuta val in vector_numeValuta)
            {
                mesaj += val.ToString();
                mesaj += ',';
            }
            return mesaj;
        }
    }
}
