using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Antra
{
    public partial class Parduotuvė : Form
    {
        private Dictionary<string, Ginklas> ginkluDictionary { get; } = new Dictionary<string, Ginklas>();
        private Dictionary<string, Drabuzis> drabuziuDictionary { get; } = new Dictionary<string, Drabuzis>();
        private Dictionary<string, Prietaisas> priestaisuDictionary { get; } = new Dictionary<string, Prietaisas>();
        private Dictionary<string, Priedai> prieduDictionary { get; } = new Dictionary<string, Priedai>();

        private List<Daiktas> krepselis = new List<Daiktas>();

        public Parduotuvė()
        {
            InitializeComponent();
           
         
        }
        private void Parduotuvė_Load(object sender, EventArgs e)
        {
            GetDaiktusMenu();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išeiti?", "Uždaryti programą", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        
        private void GetDaiktusMenu()
        {

            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=C:\Users\Domas\Desktop\Github\Antra\Failai\Medziokles.db");
            dbconnection.Open();

            // Skaityti Ginklus
            SkaitytiGinklus(dbconnection);
            dbconnection.Close();
           SQLiteConnection dbconnection1 = new SQLiteConnection(@"Data Source=C:\Users\Domas\Desktop\Github\Antra\Failai\Drabuziai.db");
            dbconnection1.Open();
            //Skaityti Drabuzius
            SkaitytiDrabuzius(dbconnection1);
            dbconnection1.Close();
            SQLiteConnection dbconnection2 = new SQLiteConnection(@"Data Source=C:\Users\Domas\Desktop\Github\Antra\Failai\Prietaisai.db");
            dbconnection2.Open();
            SkaitytiPrietaisus(dbconnection2);
            dbconnection2.Close();
            SQLiteConnection dbconnection3 = new SQLiteConnection(@"Data Source=C:\Users\Domas\Desktop\Github\Antra\Failai\Priedai.db");
            dbconnection3.Open();
            SkaitytiPriedus(dbconnection3);
            dbconnection2.Close();
        }
        

        private void ginklaiToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
            
        }

        private void lygiavamzdziaiItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytGinkloInformacija(e);

        }

        private void graiztviniaiItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytGinkloInformacija(e);
        }

        private void saudmenysItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytGinkloInformacija(e);
        }
        private void SkaitytiGinklus(SQLiteConnection connection)
        {
            string sql = "Select * FROM Ginklas";
            SQLiteDataReader reader;

            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                string pavadinimas = Convert.ToString(reader.GetValue(0));
                GinkloTipas tipas = (GinkloTipas)Enum.Parse(typeof(GinkloTipas), Convert.ToString(reader.GetValue(1)), false);
                string kalibras = Convert.ToString(reader.GetValue(2));
                double kaina = Convert.ToDouble(reader.GetValue(3));

                Ginklas ginklas = new Ginklas(pavadinimas, kaina, tipas, kalibras);
                
                ginkluDictionary.Add(pavadinimas, ginklas);

                switch (tipas)
                {
                    case GinkloTipas.Graiztvinis:
                        graižtviniaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case GinkloTipas.Lygiavamzdis:
                        lygiavamzdžiaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case GinkloTipas.Sovinys:
                        šaudmenysToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;

                }
                
                
                
            }
        }
        private void SkaitytiDrabuzius(SQLiteConnection connection)
        {
            string sql = "Select * FROM Drabuziai";
            SQLiteDataReader reader;
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pavadinimas = Convert.ToString(reader.GetValue(0));
                string dydis = Convert.ToString(reader.GetValue(1));
                double kaina = Convert.ToDouble(reader.GetValue(2));
                DrabuzioTipas tipas = (DrabuzioTipas)Enum.Parse(typeof(DrabuzioTipas), Convert.ToString(reader.GetValue(3)), false);



                Drabuzis drabuzis = new Drabuzis(tipas, dydis, pavadinimas, kaina);

                drabuziuDictionary.Add(pavadinimas, drabuzis);

                switch (tipas)
                {
                    case DrabuzioTipas.Kelnes:
                        kelnėsToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case DrabuzioTipas.Kepure:
                        kepurėsToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case DrabuzioTipas.Striuke:
                        striukėsToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;


                }

            }
        }
        private void SkaitytiPrietaisus(SQLiteConnection connection)
        {
            string sql = "Select * FROM Optika";
            SQLiteDataReader reader;
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pavadinimas = Convert.ToString(reader.GetValue(0));
                string priartinimas = Convert.ToString(reader.GetValue(1));
                string diametras = Convert.ToString(reader.GetValue(2));
                PrietaisoTipas tipas = (PrietaisoTipas)Enum.Parse(typeof(PrietaisoTipas), Convert.ToString(reader.GetValue(3)), false);
                double kaina = Convert.ToDouble(reader.GetValue(4));

                Prietaisas prietaisas = new Prietaisas(pavadinimas, kaina, priartinimas, diametras, tipas);
                priestaisuDictionary.Add(pavadinimas, prietaisas);

                switch (tipas)
                {
                    case PrietaisoTipas.Taikiklis:
                        optiniaiTaikikliaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case PrietaisoTipas.Termovizorius:
                        termovizoriaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case PrietaisoTipas.Žiūronai:
                        žiūronaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;

                }

            }
        }
        private void SkaitytiPriedus(SQLiteConnection connection)
        {
            string sql = "Select * FROM Priedai";
            SQLiteDataReader reader;
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pavadinimas = Convert.ToString(reader.GetValue(0));
                double kaina = Convert.ToDouble(reader.GetValue(1));
                PriedoTipas tipas = (PriedoTipas)Enum.Parse(typeof(PriedoTipas), Convert.ToString(reader.GetValue(2)), false);
                Priedai priedai = new Priedai(pavadinimas, kaina, tipas);
                prieduDictionary.Add(pavadinimas, priedai);
                switch (tipas)
                {
                    case PriedoTipas.Apsauga:
                        apsaugosGinklųVamzdžiamsToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case PriedoTipas.Kuprine:
                        kuprinėsToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;
                    case PriedoTipas.Prožektorius:
                        prožektoriaiToolStripMenuItem.DropDownItems.Add(pavadinimas);
                        break;

                }

            }
        }
        void RodytGinkloInformacija(ToolStripItemClickedEventArgs e)
        {
            string paspaustasPavadinimas = e.ClickedItem.Text;
            Ginklas pasirinktasGinklas = ginkluDictionary[paspaustasPavadinimas];
            pavadinimasLabel.Text = pasirinktasGinklas.Pavadinimas;
            kalibrasLable.Text = pasirinktasGinklas.Kalibras;
            kainosTextBox.Text = Convert.ToString(pasirinktasGinklas.Kaina);
            var paveiksliukoPavadinimas = pasirinktasGinklas.Pavadinimas + ".jpg";
            ginkloPictureBox.Image = new Bitmap(@"C:\Users\Domas\Desktop\Github\Antra\Failai\"+paveiksliukoPavadinimas);
            ginkloPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }
       void RodytiDrabuzioInformacija(ToolStripItemClickedEventArgs e)
        {
            string paspaustasPavadinimas = e.ClickedItem.Text;
            Drabuzis pasirinktasdrabuzis = drabuziuDictionary[paspaustasPavadinimas];
            pavadinimasLabel.Text = pasirinktasdrabuzis.Pavadinimas;
            kalibrasLable.Text = pasirinktasdrabuzis.Dydis;
            kainosTextBox.Text = Convert.ToString(pasirinktasdrabuzis.Kaina);
            var paveiksliukoPavadinimas = pasirinktasdrabuzis.Pavadinimas + ".jpg";
            ginkloPictureBox.Image = new Bitmap(@"C:\Users\Domas\Desktop\Github\Antra\Failai\" + paveiksliukoPavadinimas);
            ginkloPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void RodytiPrietaisoInformacija(ToolStripItemClickedEventArgs e)
        {
            string paspaustasPavadinimas = e.ClickedItem.Text;
           Prietaisas pasirinktasprietaisas = priestaisuDictionary[paspaustasPavadinimas];
            pavadinimasLabel.Text = pasirinktasprietaisas.Pavadinimas;
            kalibrasLable.Text = pasirinktasprietaisas.Priartinimas + " " +pasirinktasprietaisas.Diametras;
            kainosTextBox.Text = Convert.ToString(pasirinktasprietaisas.Kaina);
            var paveiksliukoPavadinimas = pasirinktasprietaisas.Pavadinimas + ".jpg";
            ginkloPictureBox.Image = new Bitmap(@"C:\Users\Domas\Desktop\Github\Antra\Failai\" + paveiksliukoPavadinimas);
            ginkloPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void RodydiPriedoInformacija(ToolStripItemClickedEventArgs e)
        {
            string paspaustasPavadinimas = e.ClickedItem.Text;
            Priedai pasirinktasprietaisas = prieduDictionary[paspaustasPavadinimas];
            pavadinimasLabel.Text = pasirinktasprietaisas.Pavadinimas;
            kalibrasLable.Text = Convert.ToString(pasirinktasprietaisas.Tipas);
            kainosTextBox.Text = Convert.ToString(pasirinktasprietaisas.Kaina);
            var paveiksliukoPavadinimas = pasirinktasprietaisas.Pavadinimas + ".jpg";
            ginkloPictureBox.Image = new Bitmap(@"C:\Users\Domas\Desktop\Github\Antra\Failai\" + paveiksliukoPavadinimas);
            ginkloPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AprangaDropDownClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiDrabuzioInformacija(e);
        }

        private void kelnesDropDownClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiDrabuzioInformacija(e);
        }

        private void KepuresDownClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiDrabuzioInformacija(e);
        }

        private void OptiniaiTaikikliaiDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiPrietaisoInformacija(e);
        }

        private void ZiuronaiDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiPrietaisoInformacija(e);
        }

        private void TermovizoriaiDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodytiPrietaisoInformacija(e);
        }

        private void ApsaugosDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodydiPriedoInformacija(e);
        }

        private void KuprinesDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodydiPriedoInformacija(e);
        }

        private void ProzektoriuDropDown(object sender, ToolStripItemClickedEventArgs e)
        {
            RodydiPriedoInformacija(e);
        }
    }
}
