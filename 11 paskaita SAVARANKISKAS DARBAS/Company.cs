using System;
using System.Collections.Generic;
using System.Text;

namespace _11_paskaita_SAVARANKISKAS_DARBAS
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ? CountryId { get; set; }

        public Company()
        {

        }

        public Company(int id, string name, int ? countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
    }
}
