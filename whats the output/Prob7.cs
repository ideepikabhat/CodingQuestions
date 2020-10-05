//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.whats_the_output
//{
//    internal class Animal

//    {

//        public virtual void Talk()

//        {

//            Console.Write("I'm Animal.");

//        }

//    }



//    internal class Cat : Animal

//    {

//        public override void Talk()

//        {

//            Console.Write("I'm Cat.");

//        }

//    }



//    internal class Tiger : Cat

//    {

//        public new void Talk()

//        {

//            Console.Write("I'm Tiger.");

//        }

//    }



//    public class Program

//    {

//        public static void Main(string[] args)

//        {

//            Animal animal = new Cat();

//            animal.Talk();

//            animal = new Tiger();

//            animal.Talk();

//        }

//    }
//}
