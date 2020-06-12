using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Mechanik
    {
        public Mechanik()
        {
            Serwis = new HashSet<Serwis>();
        }

        public int IdMechanik { get; set; }

        public virtual Osoba IdMechanikNavigation { get; set; }
        public virtual ICollection<Serwis> Serwis { get; set; }
    }
}
