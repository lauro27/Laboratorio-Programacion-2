using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Clase11.entidades;

namespace Clase11.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lp = new List<Persona>();





            /*Persona p = new Persona("Juan", "Perez", 18);
            List<Persona> lp = new List<Persona>();
            lp.Add(new Persona("a", "b", 20));
            lp.Add(new Persona("c", "d", 15));
            lp.Add(p);
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Persona>));
                XmlTextWriter writer = new XmlTextWriter("personas.xml", Encoding.UTF8);
                x.Serialize(writer, lp);
                writer.Close();
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Persona>));
                XmlTextReader reader = new XmlTextReader("personas.xml");
                List<Persona> lista = new List<Persona>();
                lista = (List<Persona>)x.Deserialize(reader);
                reader.Close();
                foreach (Persona persona in lista)
                {
                    Console.WriteLine(persona);
                }
            }
            catch (Exception)
            {

                throw;
            }



            try
            {
                
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                XmlTextWriter xmlText = new XmlTextWriter("persona.xml",Encoding.UTF8);
                xml.Serialize(xmlText, p);
                xmlText.Close();
                
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                XmlTextReader reader = new XmlTextReader("persona.xml");
                Persona persona = (Persona)serializer.Deserialize(reader);
                reader.Close();
                Console.WriteLine(persona);
            }
            catch (Exception)
            {

                throw;
            }
            
            Console.Write(p);
            Console.ReadKey();*/
        }
    }
}

/*
                 * StreamWriter text = new StreamWriter("persona.xml");
                 * xml.Serialize(text, p);
                 */
