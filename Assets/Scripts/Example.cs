using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class EmailSender : MonoBehaviour
{
    public TMP_InputField tMP_InputField;

    public void SendEmail()
    {
        string recipientEmail = tMP_InputField.text;

        // Configurar el correo electrónico
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("est.juan.guiza1@unimilitar.edu.co"); // Cambia esto por tu dirección de correo electrónico
        mail.To.Add(recipientEmail);
        mail.Subject = "Yox";
        mail.Body = "Cupon: dasdas-asggaa";

        // Configurar el cliente SMTP
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"); // Cambia esto si usas otro proveedor de correo
        smtpServer.Port = 587;
        smtpServer.Credentials = new NetworkCredential("est.juan.guiza1@unimilitar.edu.co", "tppcfgsaophvanyv"); // Cambia esto por tus credenciales de correo
        smtpServer.EnableSsl = true;

        // Manejar problemas de certificado SSL
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };

        try
        {
            smtpServer.Send(mail);
            Debug.Log("Correo enviado exitosamente a " + recipientEmail);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
        }
        catch (Exception e)
        {
            Debug.LogError("Error al enviar el correo: " + e.Message);
        }
    }
    public void cancelar(){
            Debug.Log("Ha salido");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
