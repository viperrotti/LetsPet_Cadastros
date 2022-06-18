using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class Animal
    {
        
        public Animal(string name, Specie specie, string breed, string color, Size size, double weight, 
            DateTime birth, bool agressive, char sex, bool castrated, bool needs, List<string> diseasesAlergies)
        {

            this.Code = Guid.NewGuid();
            this.Name = name;
            this.Specie = specie;
            this.Breed = breed;
            this.Color = color;
            this.Size = size;
            this.Weight = weight;
            this.Birth = birth;
            this.Agressive = agressive;
            this.Sex = sex;
            this.Castrated = castrated;
            this.SpecialNeeds = needs;
            this.diseasesAlergies = diseasesAlergies;
        }
        public Guid Code { get; private set; }
        public string Name { get; private set; }
        public Specie Specie { get; private set; }
        public string Breed { get; private set; }
        public string Color { get; private set; }
        public Size Size { get; private set; }
        public double Weight { get; private set; }
        public DateTime Birth { get; private set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var animalAge = today.Year - Birth.Year;
                if (Birth.Date > today.AddYears(-animalAge)) animalAge--;
                return animalAge;
            }
        }

        List<string> diseasesAlergies = new List<string>();
        public bool Agressive { get; private set; }
        public char Sex { get; private set; }
        public bool Castrated { get; private set; }
        public bool SpecialNeeds { get; private set; }
        private DateTime RegistrationDate { get { return DateTime.Today; } }


        public void PrintAnimal()
        {
            Console.WriteLine("Imprimindo Pet");
            Console.WriteLine($"Código do animal: {Code}");
            Console.WriteLine($"Nome do animal: {Name}");
            Console.WriteLine($"Espécie do animal: {Specie}");
            Console.WriteLine($"Raça do animal: {Breed}");
            Console.WriteLine($"Cor do animal: {Color}");
            Console.WriteLine($"Porte do animal: {Size}");
            Console.WriteLine($"Peso do animal: {Weight} kg.");
            Console.WriteLine($"Data de nascimento do animal: {Birth.ToShortDateString()}. Idade: {Age} anos.");
            Console.Write("O animal possui doença, alergia ou necessidade especial? ");

            if (SpecialNeeds)
            {
                Console.WriteLine("Sim:");
                foreach (var item in diseasesAlergies)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não possui.");
            }
            Console.Write("O animal é agressivo? ");
            if (Agressive)
            {
                Console.WriteLine("Sim.");
            }
            else
            {
                Console.WriteLine("Não.");
            }
            Console.WriteLine($"Sexo do animal: {Sex}");
            Console.Write("O animal é castrado? ");
            if (Castrated)
            {
                Console.WriteLine("Sim.");
            }
            else
            {
                Console.WriteLine("Não.");
            }
            Console.WriteLine($"Data do cadastro: {RegistrationDate.ToShortDateString()}");
        }

    }
}
