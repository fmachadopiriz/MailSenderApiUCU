//----------------------------------------------------------------------------
// <copyright file="MailSender.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------
using System;
using System.Net.Mail;

// La siguiente clase esta configurada para funcionar con un servidor de correo de GMail
namespace MailSenderApiUCU
{
    public class MailSender
    {
        private string addressFrom; // El e-mail del remitente en @gmail.com

        private string nameFrom; 
        private string passwordFrom;

        public MailSender(string addressFrom, string nameFrom, string passwordFrom)
        {
            this.addressFrom = addressFrom;
            this.nameFrom = nameFrom;
            this.passwordFrom = passwordFrom;
        }

        public bool SendMail(string addressTo, string asunto, string contenido)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(addressTo);
            msg.From = new MailAddress(this.addressFrom, this.nameFrom, System.Text.Encoding.UTF8);
            msg.Subject = asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = contenido;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            // Si vas a enviar un correo con contenido html entonces cambia el valor a true
            msg.IsBodyHtml = false;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(this.addressFrom, this.passwordFrom);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Port = 587;
            // Este es el smtp valido para Gmail
            client.Host = "smtp.gmail.com";
            // Esto es para que vaya a través de SSL que es obligatorio con GMail
            client.EnableSsl = true;

            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}