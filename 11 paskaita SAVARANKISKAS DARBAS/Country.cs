using System;
using System.Collections.Generic;
using System.Text;

namespace _11_paskaita_SAVARANKISKAS_DARBAS
{
    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool ? BelongsToEU { get; set; }

        public Country()
        {

        }

        public Country(int id, string code, string name, string continent, bool ? belongsToEu)
        {
            Id = id;
            Code = code;
            Name = name;
            Continent = continent;
            BelongsToEU = belongsToEu;
        }
    }
}

