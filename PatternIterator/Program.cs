using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    class Program
    { 
        static void Main(string[] args)
        {
            IAgrigate<Car> a = new MyAgregate<Car>();
            a.Add(new Car {Model = "Toyota"});
            a.Add(new Car {Model = "Shkoda"});
            a.Add(new Car {Model = "Infinity"});
            a.Add(new Car {Model = "Lancer"});
            a.Add(new Car {Model = "Porshe"});
            a.Add(new Car {Model = "Lotus"});
            a.Add(new Car {Model = "Lada"});

            IIterator<Car> i = a.CreateIterator();
            Car item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem());
                i.MoveNext();
                //a[2].ToString();
                Console.WriteLine(a[2]);
            }
            Console.ReadKey();
            
        }
    }
}
