using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class UserInfo
    {
        public string Name;
        public int Id=0;
        public decimal Jarimalar=0;
        public decimal sum=1;
        public UserInfo(string name)
        {
            Name=name;
            Id++;
        }

        public UserInfo(string name, decimal jarimalar) 
        { 
            Name = name;
            Id++;
            Jarimalar=jarimalar;
        }
        public void Jarima()
        {
            List<decimal> user1 = new List<decimal>();

            do
            {
                if (sum == 0)
                {
                    break;
                }
                else
                {
                    Console.Write($"Id:{Id} ga jarima qiymati:");
                    decimal sum = Convert.ToDecimal(Console.ReadLine());
                    user1.Add(sum);
                    Console.WriteLine("Yangi jarima qushildi.");

                }

            } while (sum == 0);

            foreach (decimal item in user1)
            {
                Jarimalar += item;
            }

        }
        public void UserInfo1()
        {
            
            Console.WriteLine($"Id:{Id}\nName:{Name}\nJami jarimalar:{Jarimalar}");
        }

    }
}
