using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class ZalogaPilot
    {
        public int IdZalogaPilot { get; set; }
        public int IdZaloga { get; set; }
        public int IdPilot { get; set; }

        public virtual Pilot IdPilotNavigation { get; set; }
        public virtual Zaloga IdZalogaNavigation { get; set; }
    }
}
