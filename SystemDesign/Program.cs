using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SystemDesign.IteratorPattern;
using SystemDesign.Memento;

namespace Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node root = new Node(1, null);
            //Node a = new Node(2, root);
            //Node b = new Node(3, a);
            //Node c = new Node(4, root);

            //Tree tree = new Tree(root);

            //foreach (var data in tree)
            //{
            //    Console.WriteLine(data);
            //}


            Person person = new Person("Sad");
            PersonMoodHandler handler = new PersonMoodHandler(person);

            handler.TakeSnapshot();
            person.ChangeMood("mara gese");

            handler.TakeSnapshot();
            person.ChangeMood("more nai");

            handler.TakeSnapshot();


            handler.ShowHistory();

            handler.RestoreMood();
            handler.ShowHistory();

            handler.RestoreMood();
            handler.ShowHistory();

            handler.RestoreMood();
            handler.ShowHistory();

            // principle
            // patern
            // baki ta
        }
    }
}
