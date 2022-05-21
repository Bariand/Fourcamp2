using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces
{
    internal class Mp3Player : Eletronico, IRadio, IMp3
    {
        public void Next()
        {
        }

        public void Previous()
        {
        }

        public void SelecioneEstacao(int prefixo)
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }
    }
}
