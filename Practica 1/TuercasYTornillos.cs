using System.Collections.Generic;
using System.Linq;

namespace Practica_1
{
    public class TuercasYTornillos
    {
        public List<Pieza> piezas { get; private set; }
        public Dictionary<Pieza, Pieza> Pares { get; set; }

        public TuercasYTornillos(List<Pieza> piezas)
        {
            this.piezas = piezas;
            Pares =  new Dictionary<Pieza, Pieza>();
        }

        public void Start()
        {
            foreach(var tuerca in piezas.Where(x=>x.tipo == Tipo.Tuerca))
            {
                Pares.Add(tuerca, piezas.Find(x=>x.tipo==Tipo.Tornillo && x.tamaño == tuerca.tamaño));
            }
            Print();
        }

        public void Print()
        {
            foreach(var par in Pares)
            {
                System.Console.WriteLine($"{par.Key.tipo} {par.Key.tamaño} : {par.Value.tipo} {par.Value.tamaño}");
            }
        }

    }

    public class Pieza
    {
        public Tipo tipo {get; private set;}
        public int tamaño {get; private set; }

        public Pieza(string tipo, int tamaño)
        {
            this.tamaño = tamaño;
            this.tipo = tipo == "tuerca" ? Tipo.Tuerca : Tipo.Tornillo;
        }
    }

    public enum Tipo {
        Tuerca,
        Tornillo
    }
}