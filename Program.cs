namespace Structtt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1/num2);
            
            }catch(FormatException ex)
            {
                Console.WriteLine("Format ex");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("divide");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             






        //    ValueStudent valStd;
        //    valStd.a = 345;
        //    Student std = new Student();
        //    Console.WriteLine(valStd.a);
        //}
        //struct ValueStudent
        //{
        //    public int a;
        //    public bool b;
        //    public ValueStudent()
        //    {
        //        a = 5;
        //        b = true;
        //    }
        //}
        //class Student
        //{
        //    public int a;
        //    public bool b;
        //}
        //abstract class Person
        //{
        //    public string Name { get; set; }
        }
    }
}
