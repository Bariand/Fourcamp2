﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces
{
    internal class SmartPhone : Telefone, IRadio, IMp3
    {
        public void Next()
        {
        }

        public void Previous()
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
