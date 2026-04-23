using UnityEngine;
public class FamilyMember : Person
{
    public FamilyMember(string name, int age, string location, string id)
        : base(name, age, "Civilian", location, id) { }

    public override Message GenerateMessage()
    {
        return new Message(
            "Hey, you haven't even reached the check-in counter yet? We miss you!");
    }

    public void InnocentBehavior()
    {
        Debug.Log("No suspicious intent.");
    }
}