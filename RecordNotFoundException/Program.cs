using System.Runtime.ExceptionServices;

namespace Exceptions;
class RecordNotFoundException : Exception
{
    public RecordNotFoundException(string message) : base(message)//Sending parameter to the base class by the constructor.
    {

    }
    static void Main(string[] args)
    {
        try
        {
            Find();
        }
        catch (RecordNotFoundException exception)
        {
            System.Console.WriteLine(exception.Message);
        }
        HandleException(() =>
        {
            Find();
        });
    }

    private static void HandleException(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (RecordNotFoundException exception)
        {

            System.Console.WriteLine(exception.Message);
        }
    }

    private static void Find()
    {
        List<string> students = new List<string>{
        "Serpil","Ahmet","Duru"
       };

        if (!students.Contains("Hasan"))
        {
            throw new RecordNotFoundException("Record Not Found!");
        }
        else
        {
            System.Console.WriteLine("Record Found!");
        }
    }
}
