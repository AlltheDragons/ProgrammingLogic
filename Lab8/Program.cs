using static Lab8.Animal;

namespace Lab8;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myAnimal.AnimalSound();
            myCat.AnimalSound();
            myDog.AnimalSound();
    }
}
