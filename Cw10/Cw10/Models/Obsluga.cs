using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Obsluga
    {
        public Obsluga()
        {
            ZalogaObsluga = new HashSet<ZalogaObsluga>();
        }

        public int IdObsluga { get; set; }

        public virtual Osoba IdObslugaNavigation { get; set; }
        public virtual ICollection<ZalogaObsluga> ZalogaObsluga { get; set; }
    }
}
