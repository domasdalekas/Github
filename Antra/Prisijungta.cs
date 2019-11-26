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

            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Medziokles.db");
            
            dbconnection.Open();

            // Skaityti Ginklus
            SkaitytiGinklus(dbconnection);

            



        }

        private void ginklaiToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Medziokles.db");
            string sql;
            dbconnection.Open();
            
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
        void RodytGinkloInformacija(ToolStripItemClickedEventArgs e)
        {
            string paspaustasPavadinimas = e.ClickedItem.Text;
            Ginklas pasirinktasGinklas = ginkluDictionary[paspaustasPavadinimas];
            pavadinimasLabel.Text = pasirinktasGinklas.Pavadinimas;
            kalibrasLable.Text = pasirinktasGinklas.Kalibras;
            kainosTextBox.Text = Convert.ToString(pasirinktasGinklas.Kaina);

            var paveiksliukoPavadinimas = pasirinktasGinklas.Pavadinimas + ".jpg";
            ginkloPictureBox.Image = new Bitmap(@paveiksliukoPavadinimas);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
