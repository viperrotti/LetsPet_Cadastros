namespace LetsPet_Cadastros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Lets Pet.\n");
                Console.WriteLine("Digite a opção desejada:\n");
                Console.WriteLine("1 MENU TUTOR.\n" +
                                  "2 MENU PET.\n" +
                                  "3 MENU VACINAS\n" +
                                  "4 SAIR");
                answer = Console.ReadLine();

                if (answer == "1")
                {

                    string answer1;
                    do
                    {
                        Console.WriteLine("Digite a opção desejada:\n");
                        Console.WriteLine("1 CONSULTAR TUTOR.\n" +
                                          "2 CADASTRAR TUTOR.\n" +
                                          "3 RETORNAR AO MENU PRINCIPAL");
                        answer1 = Console.ReadLine();
                        if (answer1 == "1")
                        {
                            //FALTA IMPLEMENTAR BUSCA DE TUTOR (CRIAR LISTA DE TUTORES)
                        }
                        else if (answer1 == "2")
                        {
                            //FALTA CRIAR LISTA DE TUTORES
                            //FALTA ADICIONAR A UMA LISTA DE TUTORES
                            //FALTA CRIAR LISTA DE ANIMAIS PARA O TUTOR REGISTRADO
                            var tutor = new TutorRegister();
                            var registeredTutor = tutor.RegisterTutor();
                            Console.Clear();
                            Console.WriteLine("Tutor cadastrado com sucesso!");
                            registeredTutor.PrintTutor();
                            Console.ReadLine();
                        }
                        else if (answer1 == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Esta não é uma opção válida.");
                        }
                    } while (answer1 != "3");
                }

                if (answer == "2")
                {
                    string answer2;
                    do
                    {
                        Console.WriteLine("Digite a opção desejada:\n");
                        Console.WriteLine("1 CONSULTAR PET.\n" +
                                          "2 CADASTRAR PET.\n" +
                                          "3 RETORNAR AO MENU PRINCIPAL");
                        answer2 = Console.ReadLine();
                        if (answer2 == "1")
                        {
                            ////FALTA IMPLEMENTAR BUSCA DE ANIMAIS
                        }
                        else if (answer2 == "2")
                        {

                            //FALTA PESQUISAR TUTOR PARA ASSOCIAR PET A ELE
                            //FALTA INSERIR ANIMAL NA LISTA DE ANIMAIS DO TUTOR
                            var pet = new AnimalRegister();
                            var petCadastrado = pet.RegisterAnimal();
                            Console.Clear();
                            Console.WriteLine("Pet cadastrado com sucesso!");
                            petCadastrado.PrintAnimal();
                            Console.ReadLine();
                        }
                        else if (answer2 == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Esta não é uma opção válida.");
                        }
                    } while (answer != "3");
                }

                if (answer == "3")
                {
                    string answer3;
                    do
                    {
                        Console.WriteLine("Digite a opção desejada:\n");
                        Console.WriteLine("1 CONSULTAR VACINA.\n" +
                                          "2 CADASTRAR VACINA.\n" +
                                          "3 RETORNAR AO MENU PRINCIPAL");
                        answer3 = Console.ReadLine();
                        if (answer3 == "1")
                        {
                            //FALTA IMPLEMENTAR BUSCA DE VACINA
                        }
                        else if (answer3 == "2")
                        {
                            //FALTA IMPLEMENTAR CADASTRO DE VACINA
                        }
                        else if (answer3 == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Esta não é uma opção válida.");
                        }
                    } while (answer3 != "3");
                }
            }while (answer != "4");
            
        }
    }
}
