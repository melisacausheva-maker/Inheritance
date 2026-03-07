namespace Inheritance
{
    internal class Person
    {
        public string Name { get; set; }

        public int age { get; set; }

        /*public Person() //празен констр, за да решим проблема
        {
            
        }*/
        public Person(string name) //конструктор
        {
            Name = name;
        }
        public void Sleep()
        {
            Console.WriteLine($"I am an  {this.ToString()} and I am sleeping.");

            // this - указател към текущия обект
            //To string - виртуален метод, връща името на съответната имплементация(и namespace)
        }
    }
}
 
