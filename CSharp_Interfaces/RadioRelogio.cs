using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces
{
    internal class RadioRelogio : Eletronico, IRelogio, IRadio
    {
        public void MostraHora()
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }

        public void SelecioneEstacao(int prefixo)
        {
        }
    }
}
