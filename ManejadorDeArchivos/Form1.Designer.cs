
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
            this.tvFile = new System.Windows.Forms.TreeView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.guardarInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeSesionesAnterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.labeleditar = new System.Windows.Forms.Label();
            this.editar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tvFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(968, 530);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 27;
            // 
            // tvFile
            // 
            this.tvFile.BackColor = System.Drawing.SystemColors.Control;
            this.tvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFile.ImageIndex = 0;
            this.tvFile.ImageList = this.iconList;
            this.tvFile.Location = new System.Drawing.Point(0, 0);
            this.tvFile.Name = "tvFile";
            this.tvFile.SelectedImageIndex = 0;
            this.tvFile.Size = new System.Drawing.Size(322, 530);
            this.tvFile.TabIndex = 0;
            this.tvFile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFile_AfterSelect);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Open_36502.png");
            this.iconList.Images.SetKeyName(1, "unknown_filetype_icon_177514.png");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directorios";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(3, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 406);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.editar_button);
            this.groupBox1.Controls.Add(this.labeleditar);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 100);
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
            this.info_label.Click += new System.EventHandler(this.info_label_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 21);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(636, 76);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
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
            this.btnAdelante.Location = new System.Drawing.Point(144, 1);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(27, 23);
            this.btnAdelante.TabIndex = 21;
            this.btnAdelante.Text = "❯❯";
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
            this.guardarInformacionToolStripMenuItem,
            this.informacionDeSesionesAnterioresToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // guardarInformacionToolStripMenuItem
            // 
            this.guardarInformacionToolStripMenuItem.Name = "guardarInformacionToolStripMenuItem";
            this.guardarInformacionToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.guardarInformacionToolStripMenuItem.Text = "Guardar Informacion en XML";
            // 
            // informacionDeSesionesAnterioresToolStripMenuItem
            // 
            this.informacionDeSesionesAnterioresToolStripMenuItem.Name = "informacionDeSesionesAnterioresToolStripMenuItem";
            this.informacionDeSesionesAnterioresToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.informacionDeSesionesAnterioresToolStripMenuItem.Text = "Informacion de Sesiones Anteriores";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(337, 46);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(282, 25);
            this.textBox_name.TabIndex = 2;
            // 
            // labeleditar
            // 
            this.labeleditar.AutoSize = true;
            this.labeleditar.Location = new System.Drawing.Point(334, 24);
            this.labeleditar.Name = "labeleditar";
            this.labeleditar.Size = new System.Drawing.Size(109, 18);
            this.labeleditar.TabIndex = 3;
            this.labeleditar.Text = "Editar Nombre:";
            // 
            // editar_button
            // 
            this.editar_button.Location = new System.Drawing.Point(427, 73);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(75, 23);
            this.editar_button.TabIndex = 4;
            this.editar_button.Text = "Editar";
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvFile;
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
        private System.Windows.Forms.Label labeleditar;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button editar_button;
    }
}

