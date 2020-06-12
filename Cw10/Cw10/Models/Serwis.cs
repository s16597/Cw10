using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Serwis
    {
        public int IdSerwis { get; set; }
        public int IdSamolot { get; set; }
        public int IdMechanik { get; set; }
        public DateTime Data { get; set; }
        public string Typ { get; set; }
        public string Opis { get; set; }

        public virtual Mechanik IdMechanikNavigation { get; set; }
        public virtual Samolot IdSamolotNavigation { get; set; }
    }
}
