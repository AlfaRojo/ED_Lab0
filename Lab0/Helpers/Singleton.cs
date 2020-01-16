using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0.Modelos;

namespace Lab0.Helpers
{
    public class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();
                {
                    return _instance;
                }
            }
        }
        public Stack<ActuPeliculas> Peliculas = new Stack<ActuPeliculas>();
    }
}
