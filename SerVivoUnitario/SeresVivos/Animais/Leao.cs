using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.SeresVivos.Animais
{
    class Leao : IAnimal
    {
        public Porte Porte { get => Porte.Medio; }
        public bool Vivo { get; set; }

        public Leao(bool vivo)
        {
            Vivo = vivo;
        }

        public bool Dormir(HorarioAtual horarioAtual)
        {
            return horarioAtual == HorarioAtual.Noite;
        }

        public string EmitirSom()
        {
            return "Rugido";
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
