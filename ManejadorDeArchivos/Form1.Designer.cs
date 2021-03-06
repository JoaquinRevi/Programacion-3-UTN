
namespace ManejadorDeArchivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tvFile = new System.Windows.Forms.TreeView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDescripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.Archivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extensión = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechadeCreacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamaño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectorioPrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rutacompleta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarDescripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renombrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_label = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elegirDirectorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeSesionesAnterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDescripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(968, 530);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.tvFile);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 343);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // tvFile
            // 
            this.tvFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tvFile.ContextMenuStrip = this.contextMenuStrip3;
            this.tvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFile.ImageIndex = 0;
            this.tvFile.ImageList = this.iconList;
            this.tvFile.Location = new System.Drawing.Point(3, 16);
            this.tvFile.Name = "tvFile";
            this.tvFile.SelectedImageIndex = 0;
            this.tvFile.Size = new System.Drawing.Size(471, 324);
            this.tvFile.TabIndex = 0;
            this.tvFile.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFile_NodeMouseClick);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.editarDescripciónToolStripMenuItem,
            this.verDescripciónToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 92);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarDescripciónToolStripMenuItem
            // 
            this.editarDescripciónToolStripMenuItem.Name = "editarDescripciónToolStripMenuItem";
            this.editarDescripciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarDescripciónToolStripMenuItem.Text = "Editar Descripción";
            this.editarDescripciónToolStripMenuItem.Click += new System.EventHandler(this.editarDescripciónToolStripMenuItem_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Open_36502.png");
            this.iconList.Images.SetKeyName(1, "unknown_filetype_icon_177514.png");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 187);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Archivo,
            this.Extensión,
            this.FechadeCreacion,
            this.Tamaño,
            this.DirectorioPrincipal,
            this.Rutacompleta,
            this.Descripcion});
            this.listView3.ContextMenuStrip = this.contextMenuStrip2;
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 16);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(471, 168);
            this.listView3.SmallImageList = this.iconList;
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // Archivo
            // 
            this.Archivo.Text = "Archivo";
            this.Archivo.Width = 150;
            // 
            // Extensión
            // 
            this.Extensión.Text = "Extensión";
            // 
            // FechadeCreacion
            // 
            this.FechadeCreacion.Text = "Fecha de Creación";
            this.FechadeCreacion.Width = 100;
            // 
            // Tamaño
            // 
            this.Tamaño.Text = "Tamaño";
            this.Tamaño.Width = 100;
            // 
            // DirectorioPrincipal
            // 
            this.DirectorioPrincipal.Text = "Dir P";
            this.DirectorioPrincipal.Width = 40;
            // 
            // Rutacompleta
            // 
            this.Rutacompleta.Text = "Ruta completa";
            this.Rutacompleta.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDescripcionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(184, 26);
            // 
            // cambiarDescripcionToolStripMenuItem
            // 
            this.cambiarDescripcionToolStripMenuItem.Name = "cambiarDescripcionToolStripMenuItem";
            this.cambiarDescripcionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cambiarDescripcionToolStripMenuItem.Text = "Cambiar descripcion";
            this.cambiarDescripcionToolStripMenuItem.Click += new System.EventHandler(this.cambiarDescripcionToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directorios";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(3, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 406);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renombrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // renombrarToolStripMenuItem
            // 
            this.renombrarToolStripMenuItem.Name = "renombrarToolStripMenuItem";
            this.renombrarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renombrarToolStripMenuItem.Text = "Renombrar";
            this.renombrarToolStripMenuItem.Click += new System.EventHandler(this.renombrarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.Location = new System.Drawing.Point(5, 29);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(0, 13);
            this.info_label.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 21);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(481, 76);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Location = new System.Drawing.Point(918, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "🔎";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox
            // 
            this.tbox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbox.Location = new System.Drawing.Point(810, 1);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(102, 20);
            this.tbox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(750, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Buscar:";
            // 
            // tboxRuta
            // 
            this.tboxRuta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tboxRuta.Location = new System.Drawing.Point(231, 2);
            this.tboxRuta.Name = "tboxRuta";
            this.tboxRuta.Size = new System.Drawing.Size(492, 20);
            this.tboxRuta.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(193, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ruta:";
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAdelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelante.Location = new System.Drawing.Point(144, 1);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(27, 23);
            this.btnAdelante.TabIndex = 21;
            this.btnAdelante.Text = "⟳";
            this.btnAdelante.UseVisualStyleBackColor = false;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAtras.Location = new System.Drawing.Point(111, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(27, 23);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "❮❮";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elegirDirectorioToolStripMenuItem,
            this.guardarInformacionToolStripMenuItem,
            this.informacionDeSesionesAnterioresToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // elegirDirectorioToolStripMenuItem
            // 
            this.elegirDirectorioToolStripMenuItem.Name = "elegirDirectorioToolStripMenuItem";
            this.elegirDirectorioToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.elegirDirectorioToolStripMenuItem.Text = "Agregar Directorio";
            this.elegirDirectorioToolStripMenuItem.Click += new System.EventHandler(this.elegirDirectorioToolStripMenuItem_Click);
            // 
            // guardarInformacionToolStripMenuItem
            // 
            this.guardarInformacionToolStripMenuItem.Name = "guardarInformacionToolStripMenuItem";
            this.guardarInformacionToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.guardarInformacionToolStripMenuItem.Text = "Guardar Informacion en XML";
            this.guardarInformacionToolStripMenuItem.Click += new System.EventHandler(this.guardarInformacionToolStripMenuItem_Click);
            // 
            // informacionDeSesionesAnterioresToolStripMenuItem
            // 
            this.informacionDeSesionesAnterioresToolStripMenuItem.Name = "informacionDeSesionesAnterioresToolStripMenuItem";
            this.informacionDeSesionesAnterioresToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.informacionDeSesionesAnterioresToolStripMenuItem.Text = "Informacion de Sesiones Anteriores";
            this.informacionDeSesionesAnterioresToolStripMenuItem.Click += new System.EventHandler(this.informacionDeSesionesAnterioresToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // verDescripciónToolStripMenuItem
            // 
            this.verDescripciónToolStripMenuItem.Name = "verDescripciónToolStripMenuItem";
            this.verDescripciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verDescripciónToolStripMenuItem.Text = "Ver Descripción";
            this.verDescripciónToolStripMenuItem.Click += new System.EventHandler(this.verDescripciónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogeitor de archivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeSesionesAnterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader Archivo;
        private System.Windows.Forms.ToolStripMenuItem elegirDirectorioToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renombrarToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Extensión;
        private System.Windows.Forms.ColumnHeader FechadeCreacion;
        private System.Windows.Forms.ColumnHeader Tamaño;
        private System.Windows.Forms.ColumnHeader DirectorioPrincipal;
        private System.Windows.Forms.ColumnHeader Rutacompleta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ToolStripMenuItem cambiarDescripcionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem editarDescripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDescripciónToolStripMenuItem;
    }
}

