using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.cs
{
    public class ChatMessageEventArgs : EventArgs
    {
        public string Content { get; private set; }

        public string Author { get; private set; }

        public DateTime SentOn { get; private set; }

        public ChatMessageEventArgs(string content,string author)
        {
            this.Content = content;
            this.Author = author;
            this.SentOn = DateTime.Now;
        }
    }
}
