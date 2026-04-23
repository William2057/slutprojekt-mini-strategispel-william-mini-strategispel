public class Journalist : Person
{
    public Journalist(string name, int age, string location, string id)
        : base(name, age, "Journalist", location, id) { }

    public override Message GenerateMessage()
    {
        return new Message(
            "The truth must be revealed. I'll be on the plane soon.");
           
        
    }

    public bool CrypticBehavior()
    {
        return UnityEngine.Random.value > 0.5f;
    }
}
