using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Queue cola = new Queue();
                cola.Enqueue(1);
                cola.Enqueue(2);
                cola.Enqueue(3);
                cola.Enqueue(4);
                cola.Enqueue(5);
                cola.Enqueue(6);


                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Retira de la cola: " + cola.Dequeue());
                    Console.WriteLine("Queda en la cola : " + cola.Peek());
                    Console.WriteLine();

                }

                foreach (int num in cola)
                {
                    Console.WriteLine(num);

                }
                Console.ReadLine();
            }

        }

    }
}
