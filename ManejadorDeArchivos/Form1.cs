﻿using System;
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
using System.Xml;
using System.Collections;

namespace ManejadorDeArchivos
{
    public partial class Form1 : Form
    {
        static string ruta = @"C:\";
        private string ruta2 = @"D:\";
        private bool booleano = false;
        private string rutaDeArchivoSeleccionado = string.Empty;
        List<DirectoryInfo> directoriosArbol = new List<DirectoryInfo>();


        public Form1()
        {
            InitializeComponent();
            info_label.Text = "Bienvenido!";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir1 = new DirectoryInfo(ruta);
            DirectoryInfo dir2 = new DirectoryInfo(ruta2);
            tboxRuta.Text = ruta;

        }


        private void elegirDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string path = fbd.SelectedPath;
                    DirectoryInfo di = new DirectoryInfo(path);
                    directoriosArbol.Add(di);
                    tvFile.Nodes.Add(armarArbol(di));
                }

            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                rutaDeArchivoSeleccionado = e.Item.Text;
                FileAttributes atributos = File.GetAttributes(ruta + "\\" + rutaDeArchivoSeleccionado);
                if ((atributos & FileAttributes.Directory) == FileAttributes.Directory)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            info_label.Visible = true;
            FileInfo f = new FileInfo(ruta + "\\" + rutaDeArchivoSeleccionado);
            try
            {
                info_label.Text = "archivo: " + f.Name + "\ntamaño: " + f.Length + " bytes\nfecha de modificación: " + f.LastWriteTime + "\nfecha de creación: " + f.CreationTime;

            }
            catch (Exception ez)
            {
                info_label.Text = "";
            }

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

        private void actualizar()
        {
            ruta = tboxRuta.Text;
            cargarDirectoriosyArchivos();
            booleano = false;
        }

        private void actualizarLista()
        {
            cargarDirectoriosyArchivosEnLista();
            booleano = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            retroceder();
            actualizar();
            actualizarLista();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            actualizar();
            actualizarLista();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            actualizar();
            actualizarLista();
        }

        private void cargarDirectoriosyArchivosEnLista()
        {
            DirectoryInfo listaDeArchivos;
            string archivo = string.Empty;
            try
            {
                if (booleano)
                {
                    archivo = ruta + "//" + rutaDeArchivoSeleccionado;
                    Process.Start(archivo);
                }
                else
                {
                    listaDeArchivos = new DirectoryInfo(ruta);
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                    listView3.Items.Clear();

                    foreach (var arch in archivos)
                    {
                        
                        string[] s1 = { arch.Name, arch.Extension, arch.CreationTime.ToString(), arch.Length.ToString()+" bytes", arch.Directory.ToString(), arch.DirectoryName.ToString(), string.Empty};
                        
                        listView3.Items.Add(new ListViewItem(s1,1));
                    }
                    int cont = 0;
                    foreach (var dir in directorios)
                    {
                        string[] s1 = { dir.Name, dir.Extension, dir.CreationTime.ToString(), string.Empty, dir.FullName, dir.FullName, string.Empty};
                        listView3.Items.Add(new ListViewItem(s1, 0));
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void cargarDirectoriosyArchivos()
        {
            DirectoryInfo listaDeArchivos;
            string archivo;
            try
            {
                if (booleano)
                {
                    archivo = ruta + "//" + rutaDeArchivoSeleccionado;
                    Process.Start(archivo);
                }
                else
                {
                    listaDeArchivos = new DirectoryInfo(ruta);
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                    FileInfo[] cambiarNombreArchivos = archivos;
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




        private TreeNode armarArbol(DirectoryInfo listaDeArchivos)
        {
            TreeNode treenode = new TreeNode();
            string archivo;
            try
            {
                if (booleano)
                {
                    archivo = ruta + "//" + rutaDeArchivoSeleccionado;
                    Process.Start(archivo);
                }
                else
                {
                    
                    
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                   
                    treenode = new TreeNode(listaDeArchivos.Name);
                   

                    foreach (var arch in archivos)
                    {
                        TreeNode t = new TreeNode(arch.Name, 1, 1);
                        treenode.Nodes.Add(t);  
                    }

                    foreach (var d in directorios)
                    {
                        TreeNode t = new TreeNode(d.Name, 0, 0);
                        treenode.Nodes.Add(t);
     
                    }
                    return treenode;
                }
            }
            catch (Exception ex)
            {

            }


            return treenode;
        }

        private void tvFile_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            info_label.Visible = false;

            foreach (DirectoryInfo dir in directoriosArbol)
            {

                if (dir.FullName.Contains(e.Node.Text))
                {
                    tboxRuta.Text = dir.FullName;
                    actualizar();
                    actualizarLista();
                }
     
            }

        }


        //Accion de Busqueda
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo listaDeArchivos;
            string archivo = string.Empty;
            try
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
            catch (Exception ex)
            {

            }
        }

        //Accion de renombrar
        private void renombrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileInfo f = new FileInfo(ruta + "\\" + rutaDeArchivoSeleccionado);
            try
            {
                Form2 dialog = new Form2();
                dialog.ShowDialog();
                f.MoveTo(Path.Combine(f.Directory.FullName, dialog.NuevoNombre + f.Extension));



            }
            catch (Exception ez)
            {

            }
            retroceder();
            actualizar();
            actualizarLista();
        }




        private void guardarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlWriter archivoXml = XmlWriter.Create(@"archivoxml.xml");
            archivoXml.WriteStartDocument();
            archivoXml.WriteStartElement("Ruta");
            foreach (var dirarb in directoriosArbol)
            {
                if (dirarb.Name[1].ToString() == ":")
                {
                    archivoXml.WriteStartElement("Disco_" + @dirarb.Name[0].ToString());
                }
                else archivoXml.WriteStartElement(@dirarb.Name);
                archivoXml.WriteAttributeString("Ruta",dirarb.FullName);
                archivoXml.WriteStartElement("Carpetas");
                foreach (var dir in dirarb.GetDirectories())
                {
                    archivoXml.WriteStartElement("Nombre");
                    archivoXml.WriteString(dir.Name + "");
                    archivoXml.WriteEndElement();
                    archivoXml.WriteStartElement("Ult-Modificacion");
                    archivoXml.WriteString(dir.LastAccessTime + "");
                    archivoXml.WriteEndElement();
                    archivoXml.WriteStartElement("Creacion");
                    archivoXml.WriteString(dir.CreationTime + "");
                    archivoXml.WriteEndElement();

                }
                archivoXml.WriteEndElement();
                archivoXml.WriteStartElement("Archivos");
                foreach (var arch in dirarb.GetFiles())
                {
                    archivoXml.WriteStartElement("Nombre");
                    archivoXml.WriteString(arch.Name + "");
                    archivoXml.WriteEndElement();
                    archivoXml.WriteStartElement("Tamaño");
                    archivoXml.WriteString(arch.Length + "");
                    archivoXml.WriteEndElement();
                    archivoXml.WriteStartElement("Creacion");
                    archivoXml.WriteString(arch.CreationTime + "");
                    archivoXml.WriteEndElement();
                }


                archivoXml.WriteEndElement();
                archivoXml.WriteEndElement();

            }

            archivoXml.WriteEndDocument();
            archivoXml.Close();

            MessageBox.Show("Archivo guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
  
        private void informacionDeSesionesAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument leerdocumento = new XmlDocument();
            leerdocumento.Load("archivoxml.xml");
            Form3 form3 = new Form3();
            foreach (XmlNode nodo1 in leerdocumento.DocumentElement.ChildNodes)
            {
                string ruta = nodo1.Attributes["Ruta"].Value;
                //MessageBox.Show(ruta);
                DirectoryInfo d = new DirectoryInfo(ruta);
               tvFile.Nodes.Add(armarArbol(d));
            }

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarDescripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();

            try
            {
                //cambiar desc
                dialog.ShowDialog();
                listView3.SelectedItems[0].SubItems[6].Text = dialog.NuevoNombre;

            }
            catch (Exception ez)
            {

            }
            retroceder();
            actualizar();
            actualizarLista();
        }
    }
}
