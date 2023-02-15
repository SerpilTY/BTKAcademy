namespace ProfessionalAbstraction;
class Program
{
    static void Main(string[] args)
    {
        CustomerManager cm=new CustomerManager();
        cm.Logger=new SmsLogger();
        cm.Add();
    }
}

class CustomerManager{

    public ILogger Logger { get; set; }
    public void Add(){
        Logger.Log();
       System.Console.WriteLine("Customer Added!");
    }
}

class DatabaseLogger:ILogger{

    public void Log(){
        System.Console.WriteLine("Logged To DB!");
    }
}
class SmsLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Logged To SMS!");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Logged To File!");
    }
}
interface ILogger{
    void Log();
}




