using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Items it = new Items();            
            xtraUserControl11.SetObject(it);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items2 it = new Items2();
            xtraUserControl11.SetObject(it);          
        }
    }
}
