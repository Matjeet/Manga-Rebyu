namespace PresentationLayer
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customizableTextBox1 = new PresentationLayer.CustomizableTextBox();
            this.SuspendLayout();
            // 
            // customizableTextBox1
            // 
            this.customizableTextBox1.BackColor = System.Drawing.Color.White;
            this.customizableTextBox1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.customizableTextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.customizableTextBox1.BorderRadius = 20;
            this.customizableTextBox1.BorderSize = 2;
            this.customizableTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customizableTextBox1.Location = new System.Drawing.Point(200, 164);
            this.customizableTextBox1.Multiline = false;
            this.customizableTextBox1.Name = "customizableTextBox1";
            this.customizableTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizableTextBox1.PasswordChar = true;
            this.customizableTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.customizableTextBox1.PlaceholderText = "Password";
            this.customizableTextBox1.Size = new System.Drawing.Size(250, 30);
            this.customizableTextBox1.TabIndex = 0;
            this.customizableTextBox1.Texts = "";
            this.customizableTextBox1.UnderLinedStyle = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customizableTextBox1);
            this.Name = "Start";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomizableTextBox customizableTextBox1;
    }
}