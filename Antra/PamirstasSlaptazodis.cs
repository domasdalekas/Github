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
using System.Text.RegularExpressions;

namespace Antra
{
    public partial class PamirstasSlaptazodis : Form
    {
        public PamirstasSlaptazodis()
        {
            InitializeComponent();
            Image image = new Bitmap(@"Pav54.jpg");
            this.BackgroundImage = image;
        }

        private void PamirstaslaptazodisButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Vartotojai.db");

            try
            {
                dbconnection.Open();
                string pastas = PamirstasSlaptazodisText.Text;
                string cmd = "select * from vartotojas where email='"+this.PamirstasSlaptazodisText.Text+"'";
                SQLiteCommand newcommand = new SQLiteCommand(cmd, dbconnection);
                newcommand.ExecuteNonQuery();
                SQLiteDataReader dr = newcommand.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    c++;
                }
                if (c == 1)
                {
                    MessageBox.Show("Išsiusta į el.paštą "+ pastas);

                    
                }
                else
                {
                    MessageBox.Show("Toks el.paštas neegzistuoja");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                dbconnection.Close();
            }

        }
    }
}
