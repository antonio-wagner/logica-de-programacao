using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detetive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (cbP1.Checked) { cont++; }
            if (cbP2.Checked) { cont++; }
            if (cbP3.Checked) { cont++; }
            if (cbP4.Checked) { cont++; }
            if (cbP5.Checked) { cont++; }

            switch (cont)
            {
                case 0:
                    lblResultado.Text = "Inocente";
                    pictureBox1.Image = Properties.Resources.inocente;
                    break;
                case 1:
                    lblResultado.Text = "Inocente";
                    pictureBox1.Image = Properties.Resources.inocente;
                    break;
                case 2:
                    lblResultado.Text = "Suspeito";
                    pictureBox1.Image = Properties.Resources.suspeito;
                case 3:
                    lblResultado.Text = "Cúmplice";
                    
                    break;
                case 4:
                    lblResultado.Text = "Cúmplice";
                    
                    break;
                case 5:
                    lblResultado.Text = "ASSASSINO";
                    
                    break;
                default:
                    lblResultado.Text = "Erro";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
