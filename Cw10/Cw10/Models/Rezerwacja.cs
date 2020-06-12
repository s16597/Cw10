using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Rezerwacja
    {
        public int IdRezerwacji { get; set; }
        public int IdPasazer { get; set; }
        public int IdRejsLotniczy { get; set; }

        public virtual Pasazer IdPasazerNavigation { get; set; }
        public virtual RejsLotniczy IdRejsLotniczyNavigation { get; set; }
    }
}
