using System;

namespace MailSenderApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            MailSender mailSender = new MailSender("sender@gmail.com", "Nombre", "Contraseña");
            bool sent = mailSender.SendMail("receiver@mail.com", "Asunto", "Cuerpo");
            Console.WriteLine(sent ? "Enviado." : "No enviado.");
        }
    }
}
