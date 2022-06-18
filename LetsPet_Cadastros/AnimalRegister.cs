using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class AnimalRegister
    {
        // FALTA INSERIR NA LISTA DE ANIMAIS DO TUTOR AO FINALIZAR CADASTRO
        public string GetAnimalName()
        {
            string animalName;
            do
            {
                Console.WriteLine("Insira o nome do animal:");
                animalName = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalName;
        }

        public Specie GetSpecie()
        {
            string answer;
            Specie animalSpecie = Specie.Cachorro;
            do
            {
                Console.WriteLine("Qual a espécie do animal? Digite 1 para Cachorro ou 2 para Gato");
                answer = Console.ReadLine();
                if (answer != "1" && answer != "2")
                {
                    Console.WriteLine("Opção Inválida.");
                }
                else
                {
                    animalSpecie = (Specie)(Enum.Parse(typeof(Specie), answer));
                }
            } while (answer != "1" && answer != "2");
            return animalSpecie;
        }

        public string GetBreed()
        {
            string animalBreed;
            do
            {
                Console.WriteLine("Insira a raça do Animal:");
                animalBreed = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalBreed))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalBreed;
        }

        public string GetColor()
        {
            string animalColor;
            do
            {
                Console.WriteLine("Insira a cor do animal:");
                animalColor = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalColor))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalColor;
        }

        public Size GetSize()
        {
            string answer;
            Size animalSize = Size.Pequeno;
            do
            {
                Console.WriteLine("Qual o porte do animal? Digite 1 para Pequeno ou 2 para Grande");
                answer = Console.ReadLine();
                if (answer != "1" && answer != "2")
                {
                    Console.WriteLine("Opção Inválida.");
                }
                else
                {
                    animalSize = (Size)(Enum.Parse(typeof(Size), answer));
                }
            } while (answer != "1" && answer != "2");
            return animalSize;
        }

        public double GetWeight()
        {
            double animalWeight;
            do
            {
                Console.WriteLine("Qual o peso do animal");
                if (double.TryParse(Console.ReadLine(), out animalWeight))
                {
                    if (animalWeight > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return animalWeight;
        }

        public DateTime GetBirthDate()
        {
            DateTime animalBirthDate;
            do
            {
                Console.WriteLine("Insira a data de nascimento do animal (DD/MM/AAAA):");
                if (DateTime.TryParse(Console.ReadLine(), out animalBirthDate))
                {
                    break;
                }
                Console.WriteLine("Data inválida.");
            } while (true);
            return animalBirthDate;
        }

        public char GetSex()
        {
            char animalSex;
            do
            {
                Console.WriteLine("Qual o sexo do animal. Digite M para macho ou F para fêmea.");
                if (char.TryParse(Console.ReadLine().ToUpper(), out animalSex))
                {
                    if (animalSex == 'F' || animalSex == 'M')
                    {
                        break;
                    }
                }
                Console.WriteLine("Opção inválida.");
            } while (true);
            return animalSex;
        }

        public bool GetAgressivity()
        {
            string answer;
            bool agressiveAnimal = false;
            do
            {
                Console.WriteLine("O animal é agressivo? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    agressiveAnimal = true;
                }
                else if (answer == "N")
                {
                    agressiveAnimal = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }
            } while (answer != "S" && answer != "N");
            return agressiveAnimal;
        }

        public bool GetCastration()
        {
            string answer;
            bool castratedAnimal = true;
            do
            {
                Console.WriteLine("O animal é castrado? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    castratedAnimal = true;
                }
                else if (answer == "N")
                {
                    castratedAnimal = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }
            } while (answer != "S" && answer != "N");
            return castratedAnimal;
        }

        public bool GetSpecialNeeds()
        {
            string answer;
            bool needs = false;
            do
            {
                Console.WriteLine("O animal possui alergia, doença ou necessidade especial? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    needs = true;
                }
                else if (answer == "N")
                {
                    needs = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }
            } while (answer != "S" && answer != "N");
            return needs;
        }

        public List<string> GetSpecialNeedsList()
        {
            var specialNeeds = new List<string>();
            string answer = "S";
            while (answer == "S")
            {
                Console.WriteLine("Cite a necessidade especial, doença ou alergia:");
                specialNeeds.Add(Console.ReadLine());
                Console.WriteLine("Deseja inserir mais? Digite S para sim ou N para não");
                answer = Console.ReadLine().ToUpper();
            }
            return specialNeeds;
        }

        public Animal RegisterAnimal ()
        {
            var pet = new AnimalRegister();
            var name = pet.GetAnimalName();
            var specie = pet.GetSpecie();
            var breed = pet.GetBreed();
            var color = pet.GetColor();
            var size = pet.GetSize();
            var weight = pet.GetWeight();
            var birthDate = pet.GetBirthDate();
            var castrated = pet.GetCastration();
            var agressive = pet.GetAgressivity();
            var sex = pet.GetSex();
            var needs = pet.GetSpecialNeeds();
            var needsList = new List<string>();
            if (needs)
            {
                needsList = pet.GetSpecialNeedsList();
            }

            Animal pet1 = new(name, specie, breed, color, size, weight, birthDate, agressive, sex, castrated, needs, needsList);
            return pet1;
        }


    }
}
