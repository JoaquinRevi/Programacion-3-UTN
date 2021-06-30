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
    public partial class Form2 : Form
    {
        private string nuevoNombre;
        public Form2()
        {
            InitializeComponent();
        }

        public string NuevoNombre { get => nuevoNombre; set => nuevoNombre = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoNombre = textBox1.Text;
            this.Close();
        }
    }
}
