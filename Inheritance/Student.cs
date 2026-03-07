namespace Inheritance
{
    internal class Student : Person, ICanRead, ICanWrite
        //наследява един клас, но имплементира два класа
    {
        public string School { get; set; }

        public Student(string name, string school)
            :base (name) //преизползваме базовия констр
        {
            School = school;
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
