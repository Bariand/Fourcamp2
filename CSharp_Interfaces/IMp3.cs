using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces
{
    internal interface IMp3 : IPlayer
    {
        public void Next();
        public void Previous();
    }
}
