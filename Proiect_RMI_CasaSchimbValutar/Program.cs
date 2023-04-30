using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_RMI_CasaSchimbValutar
{
    internal static class Program
    {
        private static Tranzactie t=new Tranzactie();
        private static List<Tranzactie> ListaTranzactii=new List<Tranzactie>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
