using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P1_SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Simple array , indexing

            //// Loop over incoming command-line arguments using index operator.
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine("Args: {0}", args[i]);

            //// Declare an array of local integers.
            //int[] myInts = { 10, 9, 100, 432, 9874 };

            //// Use the index operator to access each element.
            //for (int j = 0; j < myInts.Length; j++)
            //    Console.WriteLine("Index {0} = {1} ", j, myInts[j]);

            #endregion


            #region Simple Indexers on Collection of People



            Console.WriteLine("***** Fun with Indexers *****\n");
            PersonCollection myPeople = new PersonCollection();
            // Add objects with indexer syntax.
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);
            // Now obtain and display each item using indexer.
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}",
                myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);

                Console.ReadLine();
            }

            #endregion


            UseGenericListOfPeople();
        }

        private static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson", 7));
            
            // Change first person with indexer.
            myPeople[0] = new Person("Maggie", "Simpson", 2);
            
            // Now obtain and display each item using indexer.
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
        }
    }
}
