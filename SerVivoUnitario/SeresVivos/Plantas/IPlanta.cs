using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    interface IPlanta : ISerVivo
    {
        bool Fotossintese(HorarioAtual horarioAtual);
        Porte Porte { get; }
    }
}
