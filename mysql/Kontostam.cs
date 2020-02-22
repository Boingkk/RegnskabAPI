using System;
using System.Collections.Generic;

namespace RegnskabAPI.mysql
{
    public partial class Kontostam
    {
        public long Id { get; set; }
        public int Konto { get; set; }
        public DateTime Dato { get; set; }
        public string Beskrivelse { get; set; }
        public decimal Belob { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Mtts { get; set; }
    }
}
