using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Cadastros
{
    public class Tutor
    {
        public Tutor(string name, string cpf, string phoneNumber, string whatsApp, string email, string address)
        {
            this.TutorIdCode = Guid.NewGuid();
            Name = name;
            CPF = cpf;
            PhoneNumber = phoneNumber;
            WhatsApp = whatsApp;
            Email = email;
            Address = address;
        }

        public Guid TutorIdCode { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        private DateTime RegistrationDate { get { return DateTime.Today; } }

        public void PrintTutor()
        {
            Console.WriteLine("Imprimindo Tutor");
            Console.WriteLine($"Código do tutor: {TutorIdCode}");
            Console.WriteLine($"Nome do tutor: {Name}");
            Console.WriteLine($"CPF do tutor: {CPF}");
            Console.WriteLine($"Telefone do tutor: {PhoneNumber}");
            Console.WriteLine($"WhatsApp do tutor: {WhatsApp}");
            Console.WriteLine($"E-mail do tutor: {Email}");
            Console.WriteLine($"Endereço do tutor: {Address}");
            Console.WriteLine($"Data do cadastro: {RegistrationDate.ToShortDateString()}");
        }
    }
}
