using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Arvore : IPlanta
    {
        public Porte Porte { get => Porte.Grande; }
        public bool Vivo { get; set; }

        public Arvore(bool vivo)
        {
            Vivo = vivo;
        }

        public bool Fotossintese(HorarioAtual horarioAtual)
        {
            return Vivo && horarioAtual == HorarioAtual.Dia;
        }

        public bool Respirar()
        {
            return Vivo;
        }
    }
}
