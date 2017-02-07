using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class Email : MonoBehaviour {

    // Use this for initialization

    void Mail()
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("youraddress@gmail.com");
        mail.To.Add("ja.yeshwanth@gmail.com");
        mail.Subject = "Test Mail";
        mail.Body = "This is for testing SMTP mail from GMAIL";

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("codredhacker@gmail.com", "kabalida") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
        Debug.Log("success");

    }

    // Update is called once per frame
    void Update () {
        
        }
    }

