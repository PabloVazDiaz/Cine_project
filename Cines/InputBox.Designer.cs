namespace Cines
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.label1 = new System.Windows.Forms.Label();
            this.Pelicula_text_Box = new System.Windows.Forms.TextBox();
            this.Acept_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // Pelicula_text_Box
            // 
            this.Pelicula_text_Box.Location = new System.Drawing.Point(79, 45);
            this.Pelicula_text_Box.Name = "Pelicula_text_Box";
            this.Pelicula_text_Box.Size = new System.Drawing.Size(150, 20);
            this.Pelicula_text_Box.TabIndex = 1;
            // 
            // Acept_Button
            // 
            this.Acept_Button.Location = new System.Drawing.Point(235, 43);
            this.Acept_Button.Name = "Acept_Button";
            this.Acept_Button.Size = new System.Drawing.Size(75, 23);
            this.Acept_Button.TabIndex = 2;
            this.Acept_Button.Text = "Aceptar";
            this.Acept_Button.UseVisualStyleBackColor = true;
            this.Acept_Button.Click += new System.EventHandler(this.Acept_Button_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 118);
            this.Controls.Add(this.Acept_Button);
            this.Controls.Add(this.Pelicula_text_Box);
            this.Controls.Add(this.label1);
            this.Name = "InputBox";
            this.Text = "Nueva Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pelicula_text_Box;
        private System.Windows.Forms.Button Acept_Button;
    }
}