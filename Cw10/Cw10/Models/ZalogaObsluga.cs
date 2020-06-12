using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class ZalogaObsluga
    {
        public int IdZalogaObsluga { get; set; }
        public int IdZaloga { get; set; }
        public int IdObsluga { get; set; }

        public virtual Obsluga IdObslugaNavigation { get; set; }
        public virtual Zaloga IdZalogaNavigation { get; set; }
    }
}
