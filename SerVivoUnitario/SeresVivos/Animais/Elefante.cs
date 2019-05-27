using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.SeresVivos.Animais
{
    class Elefante : IAnimal
    {
        public Porte Porte { get => Porte.Grande; }
        public bool Vivo { get; set; }

        public Elefante(bool vivo)
        {
            Vivo = vivo;
        }
        public bool Dormir(HorarioAtual horarioAtual)
        {
            return horarioAtual == HorarioAtual.Noite;
        }

        public string EmitirSom()
        {
            return "Barrido";
        }

        public bool Locomover()
        {
            return Vivo;
        }

        public bool Respirar()
        {
            return Vivo;
        }
    }
}
