using System.Windows.Forms;

namespace Antra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prisijungimasButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.pamirstasSlaptazodisButton = new System.Windows.Forms.Button();
            this.iseitiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prisijungimasButton
            // 
            this.prisijungimasButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.prisijungimasButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prisijungimasButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungimasButton.Location = new System.Drawing.Point(30, 79);
            this.prisijungimasButton.Name = "prisijungimasButton";
            this.prisijungimasButton.Size = new System.Drawing.Size(87, 23);
            this.prisijungimasButton.TabIndex = 1;
            this.prisijungimasButton.Text = "Prisijungti";
            this.prisijungimasButton.UseVisualStyleBackColor = false;
            this.prisijungimasButton.Click += new System.EventHandler(this.PrisijungimasButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.registracijaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registracijaButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.registracijaButton.Location = new System.Drawing.Point(30, 108);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(87, 23);
            this.registracijaButton.TabIndex = 2;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = false;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // pamirstasSlaptazodisButton
            // 
            this.pamirstasSlaptazodisButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pamirstasSlaptazodisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pamirstasSlaptazodisButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.pamirstasSlaptazodisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pamirstasSlaptazodisButton.Location = new System.Drawing.Point(123, 79);
            this.pamirstasSlaptazodisButton.Name = "pamirstasSlaptazodisButton";
            this.pamirstasSlaptazodisButton.Size = new System.Drawing.Size(111, 52);
            this.pamirstasSlaptazodisButton.TabIndex = 3;
            this.pamirstasSlaptazodisButton.Text = "Pamiršote slaptažodį?";
            this.pamirstasSlaptazodisButton.UseVisualStyleBackColor = false;
            this.pamirstasSlaptazodisButton.Click += new System.EventHandler(this.PamirstasSlaptazodis_Click_1);
            // 
            // iseitiButton
            // 
            this.iseitiButton.BackColor = System.Drawing.Color.IndianRed;
            this.iseitiButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.iseitiButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iseitiButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.iseitiButton.Location = new System.Drawing.Point(386, 218);
            this.iseitiButton.Name = "iseitiButton";
            this.iseitiButton.Size = new System.Drawing.Size(75, 23);
            this.iseitiButton.TabIndex = 4;
            this.iseitiButton.Text = "Išeiti";
            this.iseitiButton.UseVisualStyleBackColor = false;
            this.iseitiButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medžioklės parduotuvė";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iseitiButton);
            this.Controls.Add(this.pamirstasSlaptazodisButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.prisijungimasButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prisijungimasButton;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Button pamirstasSlaptazodisButton;
        private System.Windows.Forms.Button iseitiButton;
        private Label label1;
    }
}

