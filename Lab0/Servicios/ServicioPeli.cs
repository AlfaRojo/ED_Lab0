using System.Collections.Generic;
using System.Linq;
using Lab0.Modelos;
using Lab0.Helpers;

namespace Lab0.Servicios
{
    public class ServicioPeli
    {
    public List<ActuPeliculas> Get()
    {
        var listaPeliculas = new List<ActuPeliculas>();
        if (Singleton.Instance.Peliculas.Count() > 0)
        {
            for (int i = 1; i <= Singleton.Instance.Peliculas.Count(); i++)
            {
                int j = i-1;
                if (listaPeliculas.Count() == 10)
                {
                    return listaPeliculas;
                }
                listaPeliculas.Add(Singleton.Instance.Peliculas.ElementAt(j));
            }
        }
    return listaPeliculas;
    }
    public void Post(ActuPeliculas miPelicula)
        {
            Singleton.Instance.Peliculas.Push(miPelicula);
        }
    }
}
