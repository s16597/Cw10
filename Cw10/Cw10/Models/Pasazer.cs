using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Pasazer
    {
        public Pasazer()
        {
            Rezerwacja = new HashSet<Rezerwacja>();
        }

        public int IdPasazer { get; set; }

        public virtual Osoba IdPasazerNavigation { get; set; }
        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
    }
}
