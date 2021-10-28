using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace pr_32_prakt15_4_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        public struct people
        {
            public string f;
            public string i;
            public string o;
            public int age;
            public float ves;
        }

        public static void Main()
        {
            StreamReader fileIn = new StreamReader("t.txt", Encoding.GetEncoding(1251));
            string line;
            Queue people = new Queue();
            people a;
            Console.WriteLine("возраст менее 40 лет:");
            while ((line = fileIn.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.age = int.Parse(temp[3]);
                a.ves = float.Parse(temp[4]);
                if (a.age < 40)
                {
                    Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.age + "\t" + a.ves);
                }
                else
                {
                    people.Enqueue(a);
                }
            }
            fileIn.Close();
            Console.WriteLine("40 лет и старше:");
            while (people.Count != 0)
            {
                a = (people)people.Dequeue();
                Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.age + "\t" + a.ves);
            }
            Console.ReadLine();
        }
    }
}
