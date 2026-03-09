namespace Fauna
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            base.Eat();
            Bark();
        }
        public void Bark()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
