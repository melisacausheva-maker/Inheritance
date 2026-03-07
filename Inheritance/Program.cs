namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Pesho");
            var student = new Student("Gosho", "6 Pomoshtno");
            var employee = new Employee();

            person.Sleep();
            student.Sleep();
            employee.Sleep();
            //I am a Inheritance.Person and I am sleeping.

            student.Read();
        }
    }
}