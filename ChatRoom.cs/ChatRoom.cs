using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.cs
{
    public class ChatRoom
    {
        //delegate void Handle<T>(object sender, T eventArgs)
        public event EventHandler<ChatMessageEventArgs> MessageSend;
        //both these properties are not rlly mandatory
        public List<string> Participants { get; private set; }

        public string Name { get; private set; }

        public ChatRoom(string name)
        {
            this.Name = name;
        }

        public void PublishMessage (string username, string content)
        {
            var messageArgs = new ChatMessageEventArgs(content, username);
            this.MessageSend(this , messageArgs);
        }
    }
}
