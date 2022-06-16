using System;
using System.IO;
using System.Xml.Serialization;

namespace serializarListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Comidas misComidas = new Comidas();
            misComidas.sopas.Add(new Sopas { nombre = "Sopa de Frijoles", precio = 60});
            misComidas.sopas.Add(new Sopas { nombre = "Sopa de Pollo", precio = 160 });
            misComidas.tora.Add(new Tortas { Nombre = "Torta de Res", Precio = 55 });
            misComidas.tora.Add(new Tortas { Nombre = "Torta de Pollo", Precio = 65 });

            //SERIALIZER
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Comidas), new Type[] {typeof(Sopas), typeof(Tortas)});
            Stream Mystream = new FileStream("myDoc.xml", FileMode.Create,FileAccess.Write);
            
            xmlSerializer.Serialize(Mystream, misComidas);
            Mystream.Close();

            //deserializer

            Stream stream = new FileStream("myDoc.xml", FileMode.Open, FileAccess.Read);

            Comidas comidas = (Comidas)xmlSerializer.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Restaurante SUPER MAX MAX");
            Console.WriteLine();

            foreach(Sopas x in comidas.sopas)
            {
                Console.WriteLine("Tipo de sopa: " + x.nombre + " precio: " + x.precio);
            }

            foreach (Tortas t in comidas.tora)
            {
                Console.WriteLine("Tipo de sopa: " + t.Nombre + "precio: " + t.Precio);
            }
        }
    }
}
