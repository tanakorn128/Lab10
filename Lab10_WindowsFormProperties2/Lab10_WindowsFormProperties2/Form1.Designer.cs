namespace Lab10_WindowsFormProperties2
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
            this.Form2 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.Form2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Form2.Location = new System.Drawing.Point(37, 12);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(578, 249);
            this.Form2.TabIndex = 0;
            this.Form2.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form2);
            this.Name = "Form1";
            this.Text = "Form Properties";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid Form2;
    }
}

