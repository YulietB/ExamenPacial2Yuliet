using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") // lanza un mensaje de texto si no estan completo los datos y para guardar
            {
                MessageBox.Show("Los datos no han sido completados");
            }
            else
            {
                MessageBox.Show("Tus datos han sido guardados <3");
            }// esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //sirve para limpiar la pantalla de cada caja de texto
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();// se hace de tarea
            // debe de terminar la ejecucion de la interfaz
        }
    }
}
