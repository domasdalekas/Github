namespace Antra
{
    partial class PamirstasSlaptazodis
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
            this.label1 = new System.Windows.Forms.Label();
            this.PamirstasSlaptazodisText = new System.Windows.Forms.TextBox();
            this.PamirstaslaptazodisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "El.Paštas";
            // 
            // PamirstasSlaptazodisText
            // 
            this.PamirstasSlaptazodisText.Location = new System.Drawing.Point(70, 17);
            this.PamirstasSlaptazodisText.Name = "PamirstasSlaptazodisText";
            this.PamirstasSlaptazodisText.Size = new System.Drawing.Size(100, 20);
            this.PamirstasSlaptazodisText.TabIndex = 1;
            // 
            // PamirstaslaptazodisButton
            // 
            this.PamirstaslaptazodisButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.PamirstaslaptazodisButton.Location = new System.Drawing.Point(81, 182);
            this.PamirstaslaptazodisButton.Name = "PamirstaslaptazodisButton";
            this.PamirstaslaptazodisButton.Size = new System.Drawing.Size(75, 23);
            this.PamirstaslaptazodisButton.TabIndex = 2;
            this.PamirstaslaptazodisButton.Text = "Priminti";
            this.PamirstaslaptazodisButton.UseVisualStyleBackColor = true;
            this.PamirstaslaptazodisButton.Click += new System.EventHandler(this.PamirstaslaptazodisButton_Click);
            // 
            // PamirstasSlaptazodis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.PamirstaslaptazodisButton);
            this.Controls.Add(this.PamirstasSlaptazodisText);
            this.Controls.Add(this.label1);
            this.Name = "PamirstasSlaptazodis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PamirstasSlaptazodis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PamirstasSlaptazodisText;
        private System.Windows.Forms.Button PamirstaslaptazodisButton;
    }
}