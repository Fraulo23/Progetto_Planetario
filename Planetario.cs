using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Planetario
{
    internal class Planetario
    {
        public List<Pianeta> Pianeti = new List<Pianeta>();
        public double G = 6.67;
        public double DeltaTs = 0.001;
        public Vector Forza(Pianeta p, Pianeta p2)
        {
            Vector d = p2.Posizione - p.Posizione;
            double f = (G * p2.Massa * p.Massa) / Math.Pow((d).Modulo(), 2);
            return f * d.Versore();
        }
        public Vector RisultanteForze(Pianeta p)
        {
            Vector f = new Vector(0, 0);
            for (int i = 0; i < Pianeti.Count(); i++)
            {
                if (p != Pianeti[i])
                {
                    f =f+ Forza(p, Pianeti[i]);
                }
            }
            return f;
        }
        public void Move()
        {
            Vector F = new Vector(0, 0);
            Vector a = new Vector(0, 0);
            foreach (Pianeta p in Pianeti)
            {
                F = RisultanteForze(p);
                a = F / p.Massa;
                p.Velocita = p.Velocita + a * DeltaTs;
                p.Posizione = p.Posizione + p.Velocita * DeltaTs + (a * (DeltaTs * DeltaTs) / 2);
            }
        }
        

    }
}
