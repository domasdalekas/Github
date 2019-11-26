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
        private List<Ginklas> ginklas { get; } = new List<Ginklas>();
        public Parduotuvė()
        {
            InitializeComponent();


        }
        private void Parduotuvė_Load(object sender, EventArgs e)
        {
            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Ginklas.db");
            dbconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select pavadinimas from Ginklas");
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            lygiavamzdžiaiToolStripMenuItem.DropDownItems.Add("Browning");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išeiti?", "Uždaryti programą", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void graištviniaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void GetDaiktusMenu()
        {
            List<string> vs = new List<string>();

            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Ginklas.db");

            string cmd = "select pavadinimas from Ginklas";
            string cmd1 = "select id from Ginklas";
            SQLiteCommand cmdData = new SQLiteCommand(cmd, dbconnection);
            SQLiteCommand command = new SQLiteCommand(cmd1, dbconnection);
            SQLiteDataReader reader;
            /* try
             {
                 dbconnection.Open();
                 reader = cmdData.ExecuteReader();
                 reader = command.ExecuteReader();
                 while (reader.Read())
                 {

                     string pav = reader.GetString("pavadinimas");
                     lygiavamzdžiaiToolStripMenuItem.DropDownItems.Add(pav);
                 }
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

         }*/
           


        }
    }
}
