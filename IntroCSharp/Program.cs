using System;

namespace IntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Player human = new Player();
            Player computer = new Player();


            human.name = "Frank";
            computer.name = "Brainiac";



            Console.WriteLine("Hello World!");
            Console.WriteLine(human.name);
            Console.WriteLine(computer.name);
            Console.ReadLine();
        }
    }
}
