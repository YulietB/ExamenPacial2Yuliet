using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        protected string NombreCompleto;
        protected string FechaN;
        protected int Edad;
        protected int DNI_Matricula;
        protected string Carrera_Puesto;

        public string nombrecompleto //Caja de memoria
        {
            get { return NombreCompleto; }
            set { NombreCompleto = value; }
        }
        public string fechan
        {
            get { return FechaN; }
            set { FechaN = value; }
        }
        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public int dni_matricula
        {
            get { return DNI_Matricula; }
            set { DNI_Matricula = value; }
        }
        public string carrera_Puesto
        {
            get { return Carrera_Puesto; }
            set { Carrera_Puesto = value; }
        }

        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
    }

    class Alumno :Persona //clase hija alumno
    {
     //hola como esta? soy pablo y le estoy haciendo el codigo a esta niña xd  
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {
        protected int Sueldo;
        public int sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        protected int Sueldo;
        public int sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
