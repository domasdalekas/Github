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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
        private bool TikrintiDuomenis(string vardas,string pavarde,string pastas,string slaptazodis,string slaptazodis1) 
        {
            bool arTeisingiDuomenys = false;
            if(vardas ==string.Empty)
            {
                
                MessageBox.Show("Neįvestas vardas", "Registracija", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            else if (pavarde == string.Empty)
            {

                MessageBox.Show("Neįvesta pavardė", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pastas == string.Empty)
            {

                MessageBox.Show("Neįvestas El.Paštas", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!pastas.Contains('@') || !pastas.Contains('.'))
            {
                MessageBox.Show("Blogas El.Paštas", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (slaptazodis == string.Empty)
            {

                MessageBox.Show("Neįvestas vardas", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (slaptazodis!=slaptazodis1)
            {

                MessageBox.Show("Slaptažodžiai nesutampa", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                arTeisingiDuomenys = true;
            }
            return arTeisingiDuomenys;
        }
        private void RegistruotisClick_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection dbConnection  = new SQLiteConnection(@"Data Source=Vartotojai.db");
           
            try
            {
                
                dbConnection.Open();
                
                // Tikrinimas
                bool arTeisingi = TikrintiDuomenis(vardasTextBox.Text, pavardeTextBox.Text, ElpastasTextbox.Text, slaptazodistextbox.Text,pakartotislaptazodiTextBox.Text);

                if(arTeisingi)
                {
                    SQLiteCommand cmd = new SQLiteCommand("insert into Vartotojas values(@id,@vardas,@pavarde,@email,@slaptazodis)", dbConnection);
                    cmd.Parameters.AddWithValue("@id", new Random().Next(2, 100));
                    cmd.Parameters.AddWithValue("@vardas", vardasTextBox.Text);
                    cmd.Parameters.AddWithValue("@pavarde", pavardeTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", ElpastasTextbox.Text);                  
                    cmd.Parameters.AddWithValue("@slaptazodis", slaptazodistextbox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registracija sekminga", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();                    
                }            
               
                

            }

            catch (Exception exc)
            {
               MessageBox.Show(exc.Message);
                
            }
            finally
            {
  
                    dbConnection.Close();
                
                
            }
            
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void RegistracijaIseiti_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išeiti?", "Uždaryti programą", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
