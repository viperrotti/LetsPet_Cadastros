using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class Vaccine
    {

        public Guid VaccineId { get; private set; }

        //ver se precisa do lote da vacina

        public Vaccine(VaccineType vaccineType, DateTime immunizationDate, string vaccineBatch)
        {
            this.VaccineId = Guid.NewGuid();
            this.VaccineType = vaccineType;
            this.ImmunizationDate = immunizationDate;
            this.VaccineBatch = vaccineBatch;
        }

        public Guid IdAnimal { get; private set; }
        public VaccineType VaccineType { get; private set; }

        public string VaccineBatch { get; private set; }
        public DateTime ImmunizationDate { get; private set; }

        public DateTime RegistrationDate
        {
            get
            {
                return DateTime.Today;
            }
        }

        public DateTime GetReapplicationDate()
        {
            return ImmunizationDate.AddMonths(VaccineType.VaccineValidity);
        }

    }
}
