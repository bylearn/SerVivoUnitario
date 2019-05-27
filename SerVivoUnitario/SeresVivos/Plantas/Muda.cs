using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.SeresVivos.Plantas
{
    class Muda : IPlanta
    {
        public Porte Porte { get => Porte.Pequeno; }
        public bool Vivo { get; set; }

        public Muda(bool vivo)
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
