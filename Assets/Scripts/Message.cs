public class Message
{
    public string Text;
    public Person Sender;

    public Message(string text, Person sender)
    {
        Text = text;
        Sender = sender;
    }
}