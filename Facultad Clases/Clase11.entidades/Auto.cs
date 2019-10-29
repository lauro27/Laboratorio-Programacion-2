using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Clase11.entidades
{
    class Auto:IXML
    {
        public string marca;
        public double precio;

        public Auto()
        {
            this.marca = "null";
            this.precio = 0;
        }

        public Auto(string m, double p)
        {
            this.marca = m;
            this.precio = p;
        }

        public bool Guardar(string s)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                XmlTextWriter xmlText = new XmlTextWriter(s, Encoding.UTF8);
                xml.Serialize(xmlText, this);
                xmlText.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    

        public bool Leer(string s, out object o)
        {
        try
        {
            o = this;
            XmlSerializer serializer = new XmlSerializer(typeof(Auto));
            
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

        public override string ToString()
        {
            return this.marca + " " + this.precio;
        }
    }
}
