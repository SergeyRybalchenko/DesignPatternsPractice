namespace AdapterPattern
{
    internal class Adapter : Requester, ISender
    {
        public void Send(string message)
        {
            this.SendRequest(message);
        }

        /*
        Или же

        Requester sender = new Requester();
        
        public void Send(string message)
        {
            sender.SendRequest(message);
        }
        */
    }
}
