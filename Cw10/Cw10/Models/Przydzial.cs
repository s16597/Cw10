using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Przydzial
    {
        public int IdPrzydzial { get; set; }
        public int IdZaloga { get; set; }
        public int IdRejsLotniczy { get; set; }

        public virtual RejsLotniczy IdRejsLotniczyNavigation { get; set; }
        public virtual Zaloga IdZalogaNavigation { get; set; }
    }
}
