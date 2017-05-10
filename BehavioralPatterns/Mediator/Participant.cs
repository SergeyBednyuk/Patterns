using System;

namespace Mediator
{
    class Participant
    {
        private readonly ChatRoom _chatRoom;
        private readonly string _name;

        public Participant(ChatRoom chatRoom, string name)
        {
            _chatRoom = chatRoom;
            _name = name;
            _chatRoom.SignOn(this);
        }

        public void RecieveMessage(string message, string from)
        {
            if (_name != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}",
                    _name, from, message);
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _chatRoom.Send(message, _name);
        }
    }
}
