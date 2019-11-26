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
    public partial class Prisijungimas : Form
    {
        bool prisijungtaok = false;
        public Prisijungimas()
        {
            InitializeComponent();
            Image image = new Bitmap(@"Paveiksliukas3.jpg");
            this.BackgroundImage = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=Vartotojai.db");
            
            try
            {
                dbconnection.Open();
                string cmd="select * from vartotojas where email='" + this.prisijungimoVardasTextBox.Text + "' and slaptazodis='" + this.prisijungimoSlaptazodisTextBox.Text + "'";
                SQLiteCommand createCommand = new SQLiteCommand(cmd, dbconnection);

                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    c++;
                }
                if (c == 1)
                {
                   
                    
                    this.Close();
                    Form1 f1 = new Form1();

                    f1.Close();
                    prisijungtaok = true;
                }
                else
                {
                    MessageBox.Show("Blogas prisijungimas");
                }
                    
          }
         


                

            
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                if (prisijungtaok == true)
                {
                    Parduotuvė prisijungta = new Parduotuvė();
                    
                    prisijungta.Show();
                }
                    dbconnection.Close();
            }
        }
    }
}
