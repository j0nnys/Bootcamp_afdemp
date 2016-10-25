using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        public class Order
        {
            private List<Coffe> items = new List<Coffe>();

            public void Add(Coffe coffe)
            {
                items.Add(coffe);
            }
             public double CalculateCost()
            {
                double cost = 0;
                foreach (Coffe c in items) //for (int = 0; i<items.Count; i++) , κραταει την πληροφορια της θεσης
                {
                    switch (c.size) // if (c.Type == Coffe.CoffeType.Small)
                    {
                        case Coffe.Size.Small:
                            cost += 5;
                            break;
                        case Coffe.Size.Normal:
                            cost += 10;
                            break;
                        case Coffe.Size.Double:
                            cost += 15;
                            break;
                        default:
                            break;
                    }
                }
                return cost;
            }
        }

        public class Coffe
        {
            public enum Size
            {
                Small = 100,
                Normal = 150,
                Double = 300
            }
            public Size size;

            public Coffe(Size size)
            {
                this.size = size;
            }
        }

        static void Main(string[] args)
        {
            Coffe[] coffe = new Coffe[]
            {
                    new Coffe(Coffe.Size.Small),
                    new Coffe(Coffe.Size.Normal),
                    new Coffe(Coffe.Size.Double)
            };
                for (int i = 0; i < coffe.Length; i++)
                {
                    Console.WriteLine(coffe[i].size + " coffe is " + (int)coffe[i].size + "ml." + "\"");
                }
                Console.ReadKey(); 
            }
        }
    }
