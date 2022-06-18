using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class VaccineType
    {
        public VaccineType(string vaccineName, int vaccineValidity, List<Specie> species)
        {
            this.VaccineUniqueId = Guid.NewGuid();
            this.VaccineName = vaccineName;
            this.VaccineValidity = vaccineValidity;
            this.Specie = species;
        }

        public Guid VaccineUniqueId { get; private set; }

        public string VaccineName { get; private set; }
        public int VaccineValidity { get; set; }
        public List<Specie> Specie { get; private set; }
    }
}
