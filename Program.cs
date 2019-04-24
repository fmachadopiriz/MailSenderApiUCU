using System;

namespace MailSenderApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            MailSender mailSender = new MailSender("fernando.machado@gmail.com", "Nombre");
            mailSender.GetPassword("Ingrese contraseña: ");
            bool sent = mailSender.SendMail("fmachadopiriz@mail.com", "Asunto", "Cuerpo");
            Console.WriteLine(sent ? "Enviado." : "No enviado.");
        }
    }
}
