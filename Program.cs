using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FC
{
    internal class Program
    {

        /* Створіть клас «Футбольна Команда». Клас має містити
        інформацію про гравців футбольної команди. Реалізуйте
        підтримку ітератора для класу «Футбольна Команда».
        Протестуйте можливість використання foreach для класу
        «Футбольна Команда».
        */
        static void Main(string[] args)
        {
            Player player1 = new Player("Bob", 12);
            Player player2 = new Player("Alex", 27);
            Player player3 = new Player("Oleg", 5);
            Player player4 = new Player("James", 1);


            List<Player> list = new List<Player>(4);
            list.Add(player1);
            list.Add(player2);
            list.Add(player3);
            list.Add(player4);
            Team club = new Team(list);
            foreach (Player player in club)
            {
                Console.WriteLine("-----\n"+player);
            }

            Console.ReadLine();
        }
    }
}
