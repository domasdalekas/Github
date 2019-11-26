namespace Antra
{
    partial class Prisijungimas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prisijungimoVardasTextBox = new System.Windows.Forms.TextBox();
            this.prisijungimoSlaptazodisTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(148, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "El.Paštas";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slaptažodis";
            // 
            // prisijungimoVardasTextBox
            // 
            this.prisijungimoVardasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prisijungimoVardasTextBox.Location = new System.Drawing.Point(148, 8);
            this.prisijungimoVardasTextBox.Name = "prisijungimoVardasTextBox";
            this.prisijungimoVardasTextBox.Size = new System.Drawing.Size(162, 20);
            this.prisijungimoVardasTextBox.TabIndex = 4;
            // 
            // prisijungimoSlaptazodisTextBox
            // 
            this.prisijungimoSlaptazodisTextBox.Location = new System.Drawing.Point(148, 50);
            this.prisijungimoSlaptazodisTextBox.Name = "prisijungimoSlaptazodisTextBox";
            this.prisijungimoSlaptazodisTextBox.Size = new System.Drawing.Size(162, 20);
            this.prisijungimoSlaptazodisTextBox.TabIndex = 5;
            this.prisijungimoSlaptazodisTextBox.UseSystemPasswordChar = true;
            // 
            // Prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 199);
            this.Controls.Add(this.prisijungimoSlaptazodisTextBox);
            this.Controls.Add(this.prisijungimoVardasTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prisijungimoVardasTextBox;
        private System.Windows.Forms.TextBox prisijungimoSlaptazodisTextBox;
    }
}