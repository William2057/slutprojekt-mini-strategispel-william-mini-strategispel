using UnityEngine;
public class FamilyMember : Person
{
    private static string[] possibleJobs =
    {
        "Teacher",
        "Nurse",
        "Cashier",
        "Chef",
        "Mechanic",
        "Taxi Driver"
    };
    public FamilyMember(string name, int age, string location, string id)
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
            "Hey, you haven't even reached the check-in counter yet? We miss you!",
            this
        );
    }
    public void InnocentBehavior()
    {
        Debug.Log("No suspicious intent.");
    }
}