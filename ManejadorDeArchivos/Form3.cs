using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeArchivos
{
    public partial class Form3 : Form
    {
        string informacionprevia;
        public Form3(string informacionprevia)
        {
            InitializeComponent();
            this.informacionprevia = informacionprevia;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = informacionprevia;
        }
    }
}
