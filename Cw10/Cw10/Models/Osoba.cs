using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Osoba
    {
        public int IdOsoba { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }

        public virtual Mechanik Mechanik { get; set; }
        public virtual Obsluga Obsluga { get; set; }
        public virtual Pasazer Pasazer { get; set; }
        public virtual Pilot Pilot { get; set; }
    }
}
