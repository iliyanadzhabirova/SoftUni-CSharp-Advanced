using System.Text;

namespace MailClient
{
    public class MailBox
    {

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new();
            Archive = new();
        }

       public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                if (!Inbox.Contains(mail))
                {
                    Inbox.Add(mail);
                }
            }
        }

        public bool DeleteMail(string sender)
        {
            //int productIndex = Inbox.FindIndex(x => x.Sender == sender);
            //if (productIndex < 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    Inbox.RemoveAt(productIndex);
            //    return true;

            //}
            return Inbox.Remove(Inbox.FirstOrDefault(i => i.Sender == sender));
        }
        public int ArchiveInboxMessages()
        {
            foreach (Mail mail in Inbox)
            {
                Archive.Add(mail);
            }
            Inbox.RemoveAll(item => true);

            return Archive.Count;
        }

        public string GetLongestMessage()
        {
            string longestBody = Inbox.OrderByDescending(i => i.Body).FirstOrDefault().ToString();

            return longestBody.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
