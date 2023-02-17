using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
          
            try
            { 
              Find();
                
            }
            catch  (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
               }

            HandleException(() => { Find(); });
            
            }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            {

            }
        }

        private static void Find()
            {
                List<string> students = new List<string>
            {
                "Serpil","Ahmet","Duru"
            };

                if (!students.Contains("Engin"))
                {

                    throw new RecordNotFoundException ("Record Not Found");
                }

                else
                {
                    Console.WriteLine("Record Found!");
                }
            }

         private static void ExceptionIntro()
            {
                try
                {

                    string[] students = new string[3] { "Serpil", "Ahmet", "Duru" };

                    students[3] = "Ayşe";
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
            } } } 
    

