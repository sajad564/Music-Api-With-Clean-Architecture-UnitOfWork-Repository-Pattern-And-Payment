namespace music.Infrastructure.Common.Common
{
    public class EmailConfiguration
    {
       public string From {get;set;}
       public int Port {get;set;}
       public string SmtpServer {get;set;} 
       public string Username {get;set;}
       public string Password {get;set;}
       public string Name {get;set;}
    }
}