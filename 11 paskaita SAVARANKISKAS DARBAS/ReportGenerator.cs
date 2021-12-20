using _11_paskaita_SAVARANKISKAS_DARBAS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_paskaita_SAVARANKISKAS_DARBAS
{
    public class ReportGenerator
    {
        private AircraftRepository _aircraftRepository;
        private AircraftModelRepository _aircraftModelRepository;
        private CompanyRepository _companyRepository;
        private CountryRepository _countryRepository;   
        public ReportGenerator(AircraftRepository aircraftReposity, AircraftModelRepository aircraftModelRepository, CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftReposity;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<ReportItem> report = new List<ReportItem>();
            List<Aircraft> airplanes = _aircraftRepository.Retrieve();
        }






    }
}
