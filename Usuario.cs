using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Usuario
    {
        internal static int contador=0;
        internal int id;
        internal string nombre;
        internal string anio;
        internal string mes;
        internal string dia;
        internal string password;
        internal string mail;

        public Usuario(string nombre, string anio, string mes, string dia, string password, string mail)
        {
            contador++;
            this.nombre = nombre;
            this.anio = anio;
            this.mes = mes;
            this.dia = dia;
            this.password = password;
            this.mail = mail;
            this.id = contador;
        }
        public bool validarEdad(int pegi)
        {
            int edad = DateTime.Now.Year - int.Parse(this.anio);
            return edad >= pegi;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getAnio()
        {
            return anio;
        }
        public string getMes()
        {
            return mes;
        }
        public string getDia()
        {
            return dia;
        }
        public string getPassword()
        {
            return password;
        }
        public string getMail()
        {
            return mail;
        }
        public int getId()
        {
            return id;
        }

        public void setNombre(string x)
        {
            this.nombre=x;
        }
        public void setAnio(string x)
        {
            this.anio = x;
        }
        public void setMes(string x)
        {
            this.mes = x;
        }
        public void setDia(string x)
        {
            this.dia = x;
        }
        public void setPassword(string x)
        {
            this.password = x;
        }
        public void setCorreo(string x)
        {
            this.mail = x;
        }
        public override string ToString()
        {
            return "Usuario: "+nombre+" Nacimiento: "+dia+"/"+mes+"/"+anio+" Correo: "+mail;
        }
    }
}
