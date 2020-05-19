using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.cs
{
    class Startup
    {
        static void Main()
        {
            var chatRoom = new ChatRoom("TelerikAcademyChat");

            var gosho = new SkypeClient("gosho");
            var pesho = new miRCata("pesho");
            var stamatka = new miRCata("stamatka");

            gosho.JoinChatRoom(chatRoom);
            pesho.JoinChatRoom(chatRoom);
            stamatka.JoinChatRoom(chatRoom);

            pesho.SendMessage(chatRoom, "Zdr kp haide na kupon");
            stamatka.SendMessage(chatRoom, "Pesho sorry zaeta sum imam da u4a za izpit");
            pesho.SendMessage(chatRoom, "Haide v 33");
            Console.WriteLine(pesho.History);


        }
    }
}
