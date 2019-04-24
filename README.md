
# MailSenderApiUCU
Api para enviar mensajes de correo electrónico por Gmail

Para utilizar esta biblioteca se deberá agregar una referencia a su proyecto y luego invocar el siguiente código:

```c#
MailSender mailSender = new MailSender("sender@gmail.com", "Nombre";
mailSender.GetPassword("Ingrese contraseña: ");
bool sent = mailSender.SendMail("receiver@mail.com", "Asunto", "Cuerpo");
```

El método ```SendMail()``` retorna True si el mensaje fue enviado y False en caso contrario.

:exclamation: Importante: La contraseña de la cuenta desde la que se envía el correo se pide utilizando el método ```GetPassword()```

:exclamation: Nota: Se debe activar el acceso de aplicaciones desconocidas a la cuenta de Gmail mediante el siguiente link.https://myaccount.google.com/lesssecureapps​. Una vez finalizado el ejercicio volver al mismo nivel de seguridad.