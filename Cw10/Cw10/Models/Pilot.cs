using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Pilot
    {
        public Pilot()
        {
            InverseIdPilotKapitanNavigation = new HashSet<Pilot>();
            PilotTypSamolotu = new HashSet<PilotTypSamolotu>();
            ZalogaPilot = new HashSet<ZalogaPilot>();
        }

        public int IdPilot { get; set; }
        public int IdPilotKapitan { get; set; }

        public virtual Pilot IdPilotKapitanNavigation { get; set; }
        public virtual Osoba IdPilotNavigation { get; set; }
        public virtual ICollection<Pilot> InverseIdPilotKapitanNavigation { get; set; }
        public virtual ICollection<PilotTypSamolotu> PilotTypSamolotu { get; set; }
        public virtual ICollection<ZalogaPilot> ZalogaPilot { get; set; }
    }
}
