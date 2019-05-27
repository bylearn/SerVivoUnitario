using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.SeresVivos.Animais
{
    class Gato : IAnimal
    {
        public Porte Porte { get => Porte.Pequeno; }
        public bool Vivo { get; set; }

        public Gato(bool vivo)
        {
            Vivo = vivo;
        }

        public bool Dormir(HorarioAtual horarioAtual)
        {
            return horarioAtual == HorarioAtual.Dia;
        }

        public string EmitirSom()
        {
            return "Miado";
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
