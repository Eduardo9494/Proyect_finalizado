using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_Application
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void insertar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(idtext.Text, nombretext.Text, apellidotext.Text, telfonotext.Text, direcciontext.Text, fechatext.Text);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            nombretext.Text = "";
            apellidotext.Text = "";
            telfonotext.Text = "";
            direcciontext.Text = "";
            fechatext.Text = "";
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
