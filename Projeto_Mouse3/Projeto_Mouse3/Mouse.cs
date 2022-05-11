using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Mouse3
{
    public class Mouse
    {
        public int Id { get; set; }
        public List<Defeito> Defeitos { get; set; } = new List<Defeito>();

        public Mouse(int id, bool defeito0, bool defeito1, bool defeito2, bool defeito3)
        {
            Id = id;

            if (defeito0 == true)
            {
                Defeitos.Add((Defeito).0);
            }

            if (defeito1 == true)
            {
                Defeitos.Add((Defeito).1);
            }

            if (defeito2 == true)
            {
                Defeitos.Add((Defeito).2);
            }

            if (defeito3 == true)
            {
                Defeitos.Add((Defeito).3);
            }
        }
    }
}
