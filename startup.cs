using System;

namespace Person
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string sName = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            string email = Console.ReadLine();

            Student student = null;

            try
            {
                student = new Student(fName, sName, years, email);
                Console.WriteLine($"{student.FirstName} {student.LastName} " +
                    $"{student.Age} {student.Email}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException aex)
            {
                Console.WriteLine(aex.Message);
            }
            catch (InvalidPersonNameException iex)
            {
                Console.WriteLine(iex.Message);
            }
            catch (InvalidEmailException eex)
            {
                Console.WriteLine(eex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}
