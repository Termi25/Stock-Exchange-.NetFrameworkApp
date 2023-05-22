using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_RMI_CasaSchimbValutar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tutorial1.Visible == true)
            {
                tutorial2.Visible = true;
                tutorial1.Visible = false;
                tutorial3.Visible = false;
                tutorial4.Visible = false;
            }
            else if (tutorial2.Visible == true)
                {
                    tutorial3.Visible = true;
                    tutorial1.Visible = false;
                    tutorial2.Visible = false;
                    tutorial4.Visible = false;
                }
                else if (tutorial3.Visible == true)
                    {
                    tutorial4.Visible = true;
                    tutorial1.Visible = false;
                    tutorial2.Visible = false;
                    tutorial3.Visible = false;
                    }
                    else if (tutorial4.Visible == true)
                        {
                            tutorial1.Visible = true;
                            tutorial2.Visible = false;
                            tutorial3.Visible = false;
                            tutorial4.Visible = false;
                        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tutorial1.Visible == true)
            {
                tutorial4.Visible = true;
                tutorial1.Visible = false;
                tutorial2.Visible = false;
                tutorial3.Visible = false;
            }
            else if (tutorial2.Visible == true)
            {
                tutorial1.Visible = true;
                tutorial2.Visible = false;
                tutorial3.Visible = false;
                tutorial4.Visible = false;
            }
            else if (tutorial3.Visible == true)
            {
                tutorial2.Visible = true;
                tutorial1.Visible = false;
                tutorial3.Visible = false;
                tutorial4.Visible = false;
            }
            else if (tutorial4.Visible == true)
            {
                tutorial3.Visible = true;
                tutorial1.Visible = false;
                tutorial2.Visible = false;
                tutorial4.Visible = false;
            }
        }
    }
}
