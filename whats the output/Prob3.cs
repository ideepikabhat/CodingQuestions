//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.whats_the_output
//{
//    class Prob3
//    {
//        public class Key

//        {

//            public string Name { get; set; }

//        }



//        static void Main(string[] args)

//        {

//            var dictionary = new Dictionary<Key, bool>();



//            try

//            {

//                dictionary.Add(new Key() { Name = "John" }, false);

//                dictionary.Add(new Key() { Name = "Pavel" }, true);

//                dictionary.Add(new Key() { Name = "Ivan" }, true);

//                dictionary.Add(new Key() { Name = " John" }, true);

//                dictionary.Add(new Key() { Name = "Ivan " }, false);

//                dictionary.Add(new Key() { Name = "John" }, true);

//            }

//            catch

//            {

//                Console.Write("Error; ");



//            }

//            finally

//            {

//                Console.Write($"Count is {dictionary.Count}");

//            }

//        }
//    }
//}
