using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeArchivos
{
    public partial class Form1 : Form
    {
        private string ruta = @"C:/";
        private bool booleano = false;
        private string rutaDeArchivoSeleccionado = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void loadButtonAction()
        {
            removerbarra();
            ruta = tboxRuta.Text;
            cargarDirectoriosyArchivos();
            booleano = false;
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                rutaDeArchivoSeleccionado = e.Item.Text;
                FileAttributes atributos = File.GetAttributes(ruta + "\\" + rutaDeArchivoSeleccionado);
                if ((atributos & FileAttributes.Directory) == FileAttributes.Directory) // & es un operador a nivel de bit ni idea jasj
                {
                    booleano = false;
                    tboxRuta.Text = ruta + "\\" + rutaDeArchivoSeleccionado;
                }
                else
                {
                    booleano = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retroceder();
            }
        }

        private void cargarDirectoriosyArchivos()
        {
            DirectoryInfo listaDeArchivos;
            string archivo = string.Empty;
            try
            {
                if (booleano)
                {
                    archivo = ruta + "//" + rutaDeArchivoSeleccionado;
                    FileInfo detalles = new FileInfo(archivo);
                    //info del archivo

                    Process.Start(archivo);
                }
                else
                {
                    listaDeArchivos = new DirectoryInfo(ruta);
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                    listView1.Items.Clear();

                    foreach (var arch in archivos)
                    {
                        listView1.Items.Add(arch.Name, 1);
                    }

                    foreach (var dir in directorios)
                    {
                        listView1.Items.Add(dir.Name, 0);
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            retroceder();
            loadButtonAction();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tboxRuta.Text = ruta;
            cargarDirectoriosyArchivos();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void removerbarra()
        {
            string rutaanterior = tboxRuta.Text;
            if (rutaanterior.LastIndexOf("\\") == rutaanterior.Length - 1)
            {
                tboxRuta.Text = rutaanterior.Substring(0, rutaanterior.Length - 1);
            }
        }

        private void retroceder()
        {
            try
            {
                removerbarra();
                string rutaAnterior = tboxRuta.Text;
                rutaAnterior = rutaAnterior.Substring(0, rutaAnterior.LastIndexOf("\\"));
                booleano = false;
                tboxRuta.Text = rutaAnterior;
                removerbarra();

            }
            catch (Exception e)
            {

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo listaDeArchivos;
            string archivo = string.Empty;
            try
            {
                if (booleano)
                {
                    archivo = ruta + "//" + rutaDeArchivoSeleccionado;
                    FileInfo detalles = new FileInfo(archivo);
                    //info del archivo

                    Process.Start(archivo);
                }
                else
                {
                    listaDeArchivos = new DirectoryInfo(ruta);
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                    listView1.Items.Clear();

                    foreach (var arch in archivos)
                    {
                        if (arch.Name.Contains(tbox.Text))
                        {
                            listView1.Items.Add(arch.Name, 1);
                        }
                    }

                    foreach (var dir in directorios)
                    {
                        if (dir.Name.Contains(tbox.Text))
                        {
                            listView1.Items.Add(dir.Name, 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(ruta + "\\" + rutaDeArchivoSeleccionado);
            try
            {
                info_label.Text = "archivo: " + f.Name + "  tamaño: " + f.Length + " bytes\nfecha de modificación: " + f.LastWriteTime + "\nfecha de creación: " + f.CreationTime;
            }
            catch (Exception ez)
            {
                info_label.Text = "";
            }
        }
    }
}
