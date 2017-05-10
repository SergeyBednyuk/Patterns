using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var ivan = new Participant(chatRoom, "Ivan");
            var tanya = new Participant(chatRoom, "T@ne4ka");
            var jan = new Participant(chatRoom, "JAN");

            ivan.SendMessage("Привет, сделали домашку по паттернам?");
            tanya.SendMessage("Не, даже не начинала");
            ivan.SendMessage("Ян, а ты?");
            jan.SendMessage("Забил кароч");
            ivan.SendMessage("Ну ок я тогда тоже в последний день буду делать.");

            Console.ReadKey();
        }
    }
}
