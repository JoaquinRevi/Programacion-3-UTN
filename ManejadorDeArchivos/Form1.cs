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
using System.Xml;
using System.Collections;

namespace ManejadorDeArchivos
{
    public partial class Form1 : Form
    {
        static string ruta = @"C:/";
        private string ruta2 = @"D:/";
        private bool booleano = false;
        private string rutaDeArchivoSeleccionado = string.Empty;
        DirectoryInfo dir1;
        List<DirectoryInfo> directoriosArbol = new List<DirectoryInfo>();
        List<Nodo> descripciones = new List<Nodo>();
        FileInfo[] cambiarNombreArchivos;

        public Form1()
        {
            InitializeComponent();
            info_label.Text = "Bienvenido!";
            
        }
        private void loadButtonAction()
        {
            removerbarra();
            ruta = tboxRuta.Text;
            cargarDirectoriosyArchivos();
            booleano = false;
        }

        private void loadButtonActionLista()
        {
            cargarDirectoriosyArchivosEnLista();
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

        private void cargarDirectoriosyArchivosEnLista()
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
                    listView3.Items.Clear();

                    foreach (var arch in archivos)
                    {
                        //arch.Length arch.Directory arch.DirectoryName
                        string[] s1 = { arch.Name, arch.Extension, arch.CreationTime.ToString(), arch.Length.ToString()+" bytes", arch.Directory.ToString(), arch.DirectoryName.ToString()};
                        //listView3.Items.Add(arch.Name, 1);
                        //listView3.Items.Add(new ListViewItem(new[] { arch.Name, arch.Extension, arch.CreationTime.ToString()}));
                        listView3.Items.Add(new ListViewItem(s1,1));
                    }
                    int cont = 0;
                    foreach (var dir in directorios)
                    {
                        string[] s1 = { dir.Name, dir.Extension, dir.CreationTime.ToString(), "", dir.FullName, dir.FullName};
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
                    cambiarNombreArchivos = archivos;
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
            loadButtonActionLista();        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dir1 = new DirectoryInfo(ruta);
            DirectoryInfo dir2 = new DirectoryInfo(ruta2);
            tboxRuta.Text = ruta;
            label_descripcion.Visible = false;
            label_texto_descripcion.Visible = false;
            //tvFile.Nodes.Add(armarArbol(dir1));
          
            //tvFile.Nodes.Add(armarArbol(dir2));
        }

        private TreeNode armarArbol(DirectoryInfo listaDeArchivos)
        {
            TreeNode treenode = new TreeNode();
            //DirectoryInfo listaDeArchivos;
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
                    
                    
                    FileInfo[] archivos = listaDeArchivos.GetFiles();
                    DirectoryInfo[] directorios = listaDeArchivos.GetDirectories();
                   
                    treenode = new TreeNode(listaDeArchivos.Name);
                   

                    foreach (var arch in archivos)
                    {
                        treenode.Nodes.Add("", arch.Name,1);

                        
                    }

                    foreach (var d in directorios)
                    {
                        treenode.Nodes.Add("", d.Name, 0);
                        
                    }
                    return treenode;
                }
            }
            catch (Exception ex)
            {

            }


            return treenode;
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
            loadButtonActionLista();


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
                info_label.Text = "archivo: " + f.Name + "\ntamaño: " + f.Length + " bytes\nfecha de modificación: " + f.LastWriteTime + "\nfecha de creación: " + f.CreationTime;
                
            }
            catch (Exception ez)
            {
                info_label.Text = "";
            }


        }




        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cargarDirectoriosyArchivosEnLista();
        }

        private void guardarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlWriter archivoXml = XmlWriter.Create(@"C:\Users\Reviriego\Desktop\archivoxml.xml");
            archivoXml.WriteStartDocument();
            archivoXml.WriteStartElement("Ruta");
            foreach (var dirarb in directoriosArbol)
            {

                archivoXml.WriteStartElement(@dirarb.Name);
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

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    //TreeNode treenode = new TreeNode(di.Name);
                    tvFile.Nodes.Add(armarArbol(di));
                    
                    Nodo n1 = new Nodo(di.Name, "rrr");
                    descripciones.Add(n1);
                }
                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tvFile_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvFile_Click(object sender, EventArgs e)
        {
           
        }

        private void tvFile_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            info_label.Visible = false;
            
            
            label_descripcion.Visible = true;
            label_texto_descripcion.Visible = true;
            foreach(DirectoryInfo dir in directoriosArbol) 
            {
                if(dir.FullName.Contains(e.Node.Text))
                {
                    tboxRuta.Text = dir.FullName;
                    loadButtonAction();
                    loadButtonActionLista();
                }
                
            }

            //foreach (var dir in directoriosArbol)
            //{
            foreach (var str in descripciones)
            {
                if (str.Ruta.Contains(e.Node.Text))
                {
                    label_texto_descripcion.Text = str.Descripcion;
                }
                
            }




            }

        private void renombrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////cambiar nombre de archivo
            //FileInfo f = new FileInfo(listView2.Columns);
            //foreach (var arch in cambiarNombreArchivos)
            //{
            //    if (arch.Name == listView3.SelectedItems.)
            //}
            FileInfo f = new FileInfo(ruta + "\\" + rutaDeArchivoSeleccionado);
            try
            {
                Form2 dialog = new Form2();
                dialog.ShowDialog();
                f.MoveTo(Path.Combine(f.Directory.FullName, dialog.NuevoNombre+f.Extension));
               


            }
            catch (Exception ez)
            {
               
            }
            retroceder();
            loadButtonAction();
            loadButtonActionLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form2 dialog = new Form2();
            dialog.ShowDialog();

            //Buscar cual y cambiar
            foreach (var dir in directoriosArbol)
            {
                foreach (var str in descripciones)
                {
                    if (dir.Name == str.Ruta)
                    {
                        str.Descripcion = dialog.NuevoNombre;
                        
                    }
                }
            }
            
        }

        //private void loadDescripcion() 
        //{ }

    }
}
