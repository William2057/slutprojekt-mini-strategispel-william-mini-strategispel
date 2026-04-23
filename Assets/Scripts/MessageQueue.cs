using System.Collections.Generic;

public class MessageQueue<T>
{
    private Queue<T> queue = new Queue<T>();

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        return queue.Dequeue();
    }

    public int Count()
    {
        return queue.Count;
    }
}
