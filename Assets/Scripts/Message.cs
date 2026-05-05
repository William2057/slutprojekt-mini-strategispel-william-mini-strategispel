using System;

public class Message
{
    public string Content;
    public DateTime Timestamp;
    public Person Sender;

    public Message(string content, Person sender)
    {
        Content = content;
        Sender = sender;
        Timestamp = DateTime.Now;
    }
}
