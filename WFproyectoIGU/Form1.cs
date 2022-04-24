using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFproyectoIGU
{
    public partial class Form1 : Form
    {
        MenuStrip menuStrip1;
        ToolStripMenuItem Archivo, Documento, Ayuda, Firma, Salir;
        GroupBox groupBoxInput, groupBoxProcess, groupBoxOutput;
        TextBox textBox1;
        Button button1;
        ListBox listBox1;

        public Form1()
        {
            InitializeComponent();
            GenerateControls();
        }

        public void GenerateControls()
        {
            // ! Menu stripe options
            Archivo = new ToolStripMenuItem();
            Archivo.Text = "&Archivo";
            Documento = new ToolStripMenuItem();
            Documento.Text = "&Documento";
            Ayuda = new ToolStripMenuItem();
            Ayuda.Text = "&Ayuda";

            Firma = new ToolStripMenuItem();
            Firma.Text = "&Firma";
            Firma.Click += Firma_Click;

            Salir = new ToolStripMenuItem();
            Salir.Text = "&Salir";
            Salir.Click += Salir_Click;

            // ! Load the Firma and Salir options on the contextual Archivo menu
            Archivo.DropDownItems.AddRange(new ToolStripDropDownItem[] { Firma, Salir });

            // ! Creates the stripe menu
            menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Archivo, Documento, Ayuda });
            this.Controls.Add(menuStrip1);

            // * GroupBox
            groupBoxInput = new GroupBox();
            groupBoxInput.Location = new System.Drawing.Point(60, 116);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new System.Drawing.Size(166, 215);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Entrada";
            this.Controls.Add(groupBoxInput);

            // * groupBoxProcess
            groupBoxProcess = new GroupBox();
            groupBoxProcess.Location = new System.Drawing.Point(303, 116);
            groupBoxProcess.Name = "groupBoxProcess";
            groupBoxProcess.Size = new System.Drawing.Size(166, 215);
            groupBoxProcess.TabIndex = 1;
            groupBoxProcess.TabStop = false;
            groupBoxProcess.Text = "Proceso";
            this.Controls.Add(groupBoxProcess);

            // * groupBoxOutput
            groupBoxOutput = new GroupBox();
            groupBoxOutput.Location = new System.Drawing.Point(551, 116);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new System.Drawing.Size(166, 215);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Salida";
            this.Controls.Add(groupBoxOutput);

            // * textBox1
            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(44, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 20);
            textBox1.TabIndex = 0;
            groupBoxInput.Controls.Add(textBox1);

            // * button1
            button1 = new Button();
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(46, 42);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Proceso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            groupBoxProcess.Controls.Add(button1);

            // * listBox1
            listBox1 = new ListBox();
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(26, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(120, 95);
            listBox1.TabIndex = 0;
            groupBoxOutput.Controls.Add(listBox1);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento Click");
        }
    }
}
