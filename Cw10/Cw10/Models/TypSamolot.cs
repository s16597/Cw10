using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class TypSamolot
    {
        public TypSamolot()
        {
            PilotTypSamolotu = new HashSet<PilotTypSamolotu>();
            Samolot = new HashSet<Samolot>();
        }

        public int IdTypSamolot { get; set; }
        public int LiczbaMiejsc { get; set; }
        public string Model { get; set; }
        public int ZuzyciePaliwa { get; set; }
        public int IloscPaliwa { get; set; }
        public string Producent { get; set; }

        public virtual ICollection<PilotTypSamolotu> PilotTypSamolotu { get; set; }
        public virtual ICollection<Samolot> Samolot { get; set; }
    }
}
