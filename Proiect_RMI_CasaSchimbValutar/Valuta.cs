using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_RMI_CasaSchimbValutar
{
    public interface IGenerareId
    {
        int creareId();
    }
    [Serializable]
    internal class Valuta:ICloneable,IComparable,IGenerareId
    {
        private int id;
        private string denumire_scurta;

        public Valuta()
        {
            id =creareId();
            denumire_scurta = "NLL";
        }

        public Valuta(int id,string denumire_scurta)
        {
            this.id = id;
            this.denumire_scurta = denumire_scurta;
        }

        public Valuta(string denumire_scurta)
        {
            this.id = creareId();
            this.denumire_scurta = denumire_scurta;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Denumire_scurta
        {
            get { return denumire_scurta; }
            set { denumire_scurta = value; }
        }

        public object Clone()
        {
            Valuta nou=new Valuta(this.id,this.denumire_scurta);
            return nou;
        }

        public int CompareTo(object obj)
        {
            Valuta compara = obj as Valuta;
            if (compara.id > this.id)
            {
                return -1;
            }
            else
                if (compara.id < this.id)
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
            Random rnd=new Random();
            int n = rnd.Next();
            return n;
        }

        public void apelGenId()
        {
            id=creareId();
        }

        public override string ToString()
        {
            return denumire_scurta;
        }
    }
}
