using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace แบบฝึกหัด1
{
    public partial class Form1 : Form
    {
        Button btnHello;
        public Form1()
        {
            InitializeComponent();
            btnHello = new Button();
            btnHello.Location = new Point(20, 20);
            btnHello.Text = "Hello";
            this.Controls.Add(btnHello);
            //btnHello.Click += btnHello_Click;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
