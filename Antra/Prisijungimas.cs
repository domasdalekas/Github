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
            Image image = new Bitmap(@"C:\Users\Domas\Desktop\Github\Antra\Failai\Paveiksliukas3.jpg");
            this.BackgroundImage = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbconnection = new SQLiteConnection(@"Data Source=C:\Users\Domas\Desktop\Github\Antra\Failai\Vartotojai.db");
            
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

                    
                    this.Hide();
                    Parduotuvė prisijungta = new Parduotuvė();
                    prisijungta.Show();




                }
                    dbconnection.Close();
            }
        }
    }
}
