using System.Collections.Generic;

namespace Mediator
{
    class ChatRoom
    {
        private readonly IList<Participant> _participants = 
            new List<Participant>();


        public void SignOn(Participant participant)
        {
            _participants.Add(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var participant in _participants)
            {
                participant.RecieveMessage(message, from);
            }
        }
    }
}
