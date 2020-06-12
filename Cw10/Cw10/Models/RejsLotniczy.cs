using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class RejsLotniczy
    {
        public RejsLotniczy()
        {
            Przydzial = new HashSet<Przydzial>();
            Rezerwacja = new HashSet<Rezerwacja>();
        }

        public int IdRejsLotniczy { get; set; }
        public int IdSamolot { get; set; }
        public DateTime DataOdlotu { get; set; }
        public string NumerBramki { get; set; }
        public string GodzinaOdlotu { get; set; }
        public int Dystans { get; set; }
        public string Skad { get; set; }
        public string Dokad { get; set; }

        public virtual Samolot IdSamolotNavigation { get; set; }
        public virtual ICollection<Przydzial> Przydzial { get; set; }
        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
    }
}
