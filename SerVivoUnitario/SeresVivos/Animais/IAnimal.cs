using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    interface IAnimal :ISerVivo
    {
        Porte Porte { get; }
        bool Locomover();
        string EmitirSom();
        bool Dormir(HorarioAtual horarioAtual);
    }
}
