using System;
using System.Collections.Generic;
using System.Text;

namespace serializarListas
{
    [Serializable]
    public class Sopas
    {

        public Sopas() { }

        public string nombre { get; set; }
        public int precio { get; set; }
    }
}
