using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Zaloga
    {
        public Zaloga()
        {
            Przydzial = new HashSet<Przydzial>();
            ZalogaObsluga = new HashSet<ZalogaObsluga>();
            ZalogaPilot = new HashSet<ZalogaPilot>();
        }

        public int IdZaloga { get; set; }

        public virtual ICollection<Przydzial> Przydzial { get; set; }
        public virtual ICollection<ZalogaObsluga> ZalogaObsluga { get; set; }
        public virtual ICollection<ZalogaPilot> ZalogaPilot { get; set; }
    }
}
