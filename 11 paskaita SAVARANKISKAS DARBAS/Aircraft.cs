using System;
using System.Collections.Generic;
using System.Text;

namespace _11_paskaita_SAVARANKISKAS_DARBAS
{
    public class Aircraft
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string TailNumber { get; set; }

        public Aircraft()
        {

        }

        public Aircraft(int id, int modelId, int companyId, string tailNUmber)
        {
            Id = id;
            ModelId = modelId;
            CompanyId = companyId;
            TailNumber = tailNUmber;
        } 
    }
}