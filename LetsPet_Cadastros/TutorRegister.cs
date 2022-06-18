using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class TutorRegister
    {
        public string GetTutorName()
        {
            string tutorName;
            do
            {
                Console.WriteLine("Insira o nome do tutor:");
                tutorName = Console.ReadLine();
                if (!string.IsNullOrEmpty(tutorName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return tutorName;
        }

        public string GetCPF()
        {
            string cpf;
            do
            {
                Console.WriteLine("Insira o cpf do tutor (com pontos e hífen):");
                cpf = Console.ReadLine();
                if (!string.IsNullOrEmpty(cpf))
                {
                    Regex regex = new Regex(@"\b\d{3}\.\d{3}\.\d{3}-\d{2}\b");
                    var validCPF = regex.Match(cpf);
                    if (validCPF.Success)
                    {
                        break;
                    }
                }
                Console.WriteLine("CPF inválido.");
            } while (true);
            return cpf;
        }

        public string GetPhoneNumber()
        {
            //falta validar entrada do telefone
            string phone;
            do
            {
                Console.WriteLine("Insira o telefone do tutor:");
                phone = Console.ReadLine();
                if (!string.IsNullOrEmpty(phone))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return phone;
        }

        public string GetWhatsApp()
        {
            //validar telefone
            string whatsApp;
            do
            {
                Console.WriteLine("Insira o contato de whatsApp do tutor:");
                whatsApp = Console.ReadLine();
                if (!string.IsNullOrEmpty(whatsApp))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return whatsApp;
        }

        public string GetEmail()
        {
            string email;
            do
            {
                Console.WriteLine("Insira o contato de e-mail do tutor:");
                email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email))
                {
                    Regex regex = new Regex(@"\b([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)\b");
                    var validEmail = regex.Match(email);
                    if (validEmail.Success)
                    {
                        break;
                    }
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return email;
        }

        public string GetAddress()
        {
            //validar endereço?? criar classe EndereçoCompleto?
            string address;
            do
            {
                Console.WriteLine("Insira o endereço do tutor:");
                address = Console.ReadLine();
                if (!string.IsNullOrEmpty(address))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return address;
        }

        public Tutor RegisterTutor()
        {
            var tutor = new TutorRegister();
            var name = tutor.GetTutorName();
            var cpf = tutor.GetCPF();
            var phonenumber = tutor.GetPhoneNumber();
            var whatsApp = tutor.GetWhatsApp();
            var email = tutor.GetEmail();
            var address = tutor.GetAddress();


            Tutor tutor1 = new(name, cpf, phonenumber, whatsApp, email, address);
            return tutor1;
        }

    }
}
