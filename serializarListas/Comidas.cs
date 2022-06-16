using System;
using System.Collections.Generic;
using System.Text;

namespace serializarListas
{
    
    [Serializable]
    public class Comidas
    {
        
        public Comidas() { }
        public List<Sopas> sopas = new List<Sopas> ();
        public List<Tortas> tora = new List<Tortas>();



    }
}
