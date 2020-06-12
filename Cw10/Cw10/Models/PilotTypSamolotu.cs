using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class PilotTypSamolotu
    {
        public int IdPilotTypSamolotu { get; set; }
        public int IdPilot { get; set; }
        public int IdTypSamolotu { get; set; }

        public virtual Pilot IdPilotNavigation { get; set; }
        public virtual TypSamolot IdTypSamolotuNavigation { get; set; }
    }
}
