using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
public class DisplayMessage : MonoBehaviour
{
    public GameObject Message;
    void Start()
    {
    
        Message = GameObject.Find("message");
        //Message.SetActive(false);
        //Message.SetActive(true);
    }


    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.Y))
        {
            
            Mail();
            GameObject.Destroy(this);
            GetComponent<TextMesh>().text = "Message sent!!";

        }

        if (Input.GetKey(KeyCode.N))
        {

            GetComponent<TextMesh>().text = "User removed!!";

        }

    }

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



}





