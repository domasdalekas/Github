using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antra
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Image image = new Bitmap(@"Paveiksliukas1.jpg");
            this.BackgroundImage = image;

        }


        private void PrisijungimasButton_Click(object sender, EventArgs e)
        {
            Prisijungimas prisijungimas = new Prisijungimas();
            Form1 f1 = new Form1();
            f1.Close();
            prisijungimas.ShowDialog();
        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void PamirstasSlaptazodis_Click(object sender, EventArgs e)
        {
            PamirstasSlaptazodis pamirstasSlaptazodis = new PamirstasSlaptazodis();
            pamirstasSlaptazodis.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išeiti?", "Uždaryti programą", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void PamirstasSlaptazodis_Click_1(object sender, EventArgs e)
        {

        }

    }
}
