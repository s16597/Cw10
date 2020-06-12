using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Samolot
    {
        public Samolot()
        {
            RejsLotniczy = new HashSet<RejsLotniczy>();
            Serwis = new HashSet<Serwis>();
        }

        public int IdSamolot { get; set; }
        public int IdTypSamolotu { get; set; }
        public DateTime DataProdukcji { get; set; }

        public virtual TypSamolot IdTypSamolotuNavigation { get; set; }
        public virtual ICollection<RejsLotniczy> RejsLotniczy { get; set; }
        public virtual ICollection<Serwis> Serwis { get; set; }
    }
}
