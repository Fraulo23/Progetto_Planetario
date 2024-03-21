using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Planetario
{
    internal class Pianeta
    {
        public double Massa { get; set; }
        public Vector Velocita { get; set; }
        public Vector Posizione { get; set; }
        public string Colore { get; set; }
        public Pianeta(double massa, Vector velocita, Vector posizione, string colore)
        {
            Massa = massa;
            Velocita = velocita;
            Posizione = posizione;
            Colore = colore;
        }
        public Pianeta() { }
        public static Pianeta Parse(string s)
        {
            string[] parts = s.Split(',');
            return new Pianeta(double.Parse(parts[0]), Vector.Parse(parts[1]), Vector.Parse(parts[2]),parts[3]);
        }
        public static bool TryParse(string a, out Pianeta p)
        {
            try
            {
                p = Pianeta.Parse(a);
                return true;
            }
            catch
            {
                p = null;
                return false;
            }
        }
        public override string ToString()
        {
            return Massa+","+Velocita+","+Posizione+","+Colore;
        }
    }
}
