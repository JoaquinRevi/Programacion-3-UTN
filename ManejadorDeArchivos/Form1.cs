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
        static string ruta = @"C:\";
        private string comentario = string.Empty;
        private string ruta2 = @"D:\";
        private bool booleano = false;
        private string rutaDeArchivoSeleccionado = string.Empty;
        List<DirectoryInfo> directoriosArbol = new List<DirectoryInfo>();
        List<string> comentarios = new List<string>();

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
                if (dir.Exists)
                {
                    if (dir.FullName.Contains(e.Node.Text))
                    {
                        tboxRuta.Text = dir.FullName;
                        actualizar();
                        actualizarLista();
                        //MessageBox.Show("enre mal");
                    }
                }
                else 
                {
                    //XmlDocument leerdocumento = new XmlDocument();
                    //leerdocumento.Load("archivoxml.xml");
                    //ListViewItem lvi3 = new ListViewItem(dir.Name);
                    //foreach (XmlNode nodo1 in leerdocumento.DocumentElement.ChildNodes)
                    //{
                    //    string ruta = nodo1.Attributes["Ruta"].Value;
                    //    //MessageBox.Show("entre bien");
                        
                    //    //booleano = false;
                    //    if (dir.FullName == ruta)
                    //    {
                    //        //nodo1.Name y nodo.Inndertext
                    //        foreach (XmlNode nodoshijos in nodo1.ChildNodes)
                    //        {
                    //            foreach (XmlNode nodosinformacion in nodoshijos.ChildNodes)
                    //            {
                    //                if (booleano)
                    //                {
                    //                    ListViewItem.ListViewSubItem lvi = new ListViewItem.ListViewSubItem(nodosinformacion.Attributes["Nombre"].Value, 1, 1);
                    //                    lvi3.SubItems.Add(lvi);

                    //                }
                    //                else
                    //                {
                    //                    TreeNode nodohijo = new TreeNode(nodosinformacion.Attributes["Nombre"].Value, 0, 0);
                    //                    tnExist.Nodes.Add(nodohijo);

                    //                }

                    //            }
                    //            booleano = true;
                    //        }


                    //    }
                    //    tvFile.Nodes.Add(tnExist);
                    //    booleano = false;

                    //    //--

                    //    listView3.Items.Clear();

                        //foreach (var arch in archivos)
                        //{

                        //    string[] s1 = { arch.Name, arch.Extension, arch.CreationTime.ToString(), arch.Length.ToString() + " bytes", arch.Directory.ToString(), arch.DirectoryName.ToString(), string.Empty };

                        //    listView3.Items.Add(new ListViewItem(s1, 1));
                        //}
                        //int cont = 0;
                        //foreach (var dir in directorios)
                        //{
                        //    string[] s1 = { dir.Name, dir.Extension, dir.CreationTime.ToString(), string.Empty, dir.FullName, dir.FullName, string.Empty };
                        //    listView3.Items.Add(new ListViewItem(s1, 0));
                        //}
                    //}
                
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
        { int cont = 0;
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
                foreach (var com in comentarios)
                {
                    if (com[0].ToString().Equals(cont.ToString()))
                    {
                        MessageBox.Show("mensaje guardado: "+ com);
                        archivoXml.WriteAttributeString("Comentario", com);
                        cont++;
                        break;
                    }
                }
                archivoXml.WriteAttributeString("Ruta",dirarb.FullName);
               
                archivoXml.WriteStartElement("Carpetas");
                foreach (var dir in dirarb.GetDirectories())
                {
                    archivoXml.WriteStartElement("Directory");
                    archivoXml.WriteAttributeString("Nombre", dir.Name);
                    archivoXml.WriteAttributeString("Ult-Modificacion", dir.LastAccessTime.ToString());
                    archivoXml.WriteAttributeString("Creacion", dir.CreationTime.ToString());
                    archivoXml.WriteEndElement();
                    //archivoXml.WriteStartElement("Nombre");
                    //archivoXml.WriteString(dir.Name + "");
                    //archivoXml.WriteEndElement();
                    //archivoXml.WriteStartElement("Ult-Modificacion");
                    //archivoXml.WriteString(dir.LastAccessTime + "");
                    //archivoXml.WriteEndElement();
                    //archivoXml.WriteStartElement("Creacion");
                    //archivoXml.WriteString(dir.CreationTime + "");
                    //archivoXml.WriteEndElement();

                }
                archivoXml.WriteEndElement();
                archivoXml.WriteStartElement("Archivos");
                foreach (var arch in dirarb.GetFiles())
                {
                    archivoXml.WriteStartElement("File");
                    archivoXml.WriteAttributeString("Nombre", arch.Name);
                    archivoXml.WriteAttributeString("Tamaño", arch.Length.ToString());
                    archivoXml.WriteAttributeString("Creacion", arch.CreationTime.ToString());
                    archivoXml.WriteEndElement();

                    //archivoXml.WriteStartElement("Nombre");
                    //archivoXml.WriteString(arch.Name + "");
                    //archivoXml.WriteEndElement();
                    //archivoXml.WriteStartElement("Tamaño");
                    //archivoXml.WriteString(arch.Length + "");
                    //archivoXml.WriteEndElement();
                    //archivoXml.WriteStartElement("Creacion");
                    //archivoXml.WriteString(arch.CreationTime + "");
                    //archivoXml.WriteEndElement();
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
            string leerComentario = string.Empty;
            XmlDocument leerdocumento = new XmlDocument();
            leerdocumento.Load("archivoxml.xml");
            foreach (XmlNode nodo1 in leerdocumento.DocumentElement.ChildNodes)
            {
                string ruta = nodo1.Attributes["Ruta"].Value;
                //MessageBox.Show(ruta);
                DirectoryInfo d = new DirectoryInfo(ruta);
                if (d.Exists)
                {
                    tvFile.Nodes.Add(armarArbol(d));
                    directoriosArbol.Add(d);
                    foreach(TreeNode nod in tvFile.Nodes) 
                    {
                        if (nod.Text == d.Name) 
                        {
                            nod.Name = nodo1.Attributes["Comentario"].Value.Remove(0, 1);
                        }
                    }
                }
                else
                {
                    
                    TreeNode tnExist = new TreeNode(d.Name);
                    booleano = false;
                    if (d.FullName == ruta)
                    {
                        //nodo1.Name y nodo.Inndertext
                        foreach (XmlNode nodoshijos in nodo1.ChildNodes)
                        {
                            foreach (XmlNode nodosinformacion in nodoshijos.ChildNodes)
                            {
                                if (booleano)
                                {
                                    TreeNode nodohijo = new TreeNode(nodosinformacion.Attributes["Nombre"].Value, 1, 1);
                                    tnExist.Nodes.Add(nodohijo);
                                    
                                }
                                else
                                {
                                    TreeNode nodohijo = new TreeNode(nodosinformacion.Attributes["Nombre"].Value, 0, 0);
                                    tnExist.Nodes.Add(nodohijo);
                                    
                                }
                                
                            }
                            booleano = true;
                        }


                    }
                    tvFile.Nodes.Add(tnExist);
                    //foreach (TreeNode nod in tvFile.Nodes)
                    //{
                    //    if (nod.Text == d.Name)
                    //    {
                    //        nod.Name = nodo1.Attributes["Comentario"].Value;
                    //    }
                    //}
                    booleano = false;
                }

 
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var dir in comentarios)
            {
                MessageBox.Show(dir);
            }
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

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directoriosArbol.RemoveAt(tvFile.SelectedNode.Index);
            tvFile.SelectedNode.Remove();
        }

        private void editarDescripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            comentario = form2.NuevoNombre; // añade comentario
            tvFile.SelectedNode.Name = comentario;
            comentarios.Add(tvFile.SelectedNode.Index+comentario);
        }

        private void verDescripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Descripción de " + tvFile.SelectedNode.Text + ": " + tvFile.SelectedNode.Name);
            } catch(Exception ex) 
            {
                MessageBox.Show("Aún no tiene descripción!");
            }
            //MessageBox.Show(comentarios[tvFile.SelectedNode.Index]);
        }
    }
}
