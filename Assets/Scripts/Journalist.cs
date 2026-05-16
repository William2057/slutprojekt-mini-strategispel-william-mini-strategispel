using UnityEngine;
public class Journalist : Person
{
    private static string[] possibleJobs =
    {
        "Reporter",
        "News Editor",
        "Photojournalist",
        "War Correspondent",
        "Media Analyst"
    };
    public Journalist(string name, int age, string location, string id)
        : base(
            name,
            age,
            possibleJobs[Random.Range(0, possibleJobs.Length)],
            location,
            id)
    {
    }
    public override Message GenerateMessage()
    {
        return new Message(
            "The truth must be revealed. I'll be on the plane soon.",
            this
        );
    }
    public bool CrypticBehavior()
    {
        return Random.value > 0.5f;
    }
}
