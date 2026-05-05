public class Criminal : Person
{
    public string Specialty;

    public Criminal(string name, int age, string location, string id, string specialty)
        : base(name, age, "Criminal", location, id)
    {
        Specialty = specialty;
        CriminalRecord.Add("Drug smuggling");
    }

    public override Message GenerateMessage()
    {
        return new Message(
            "Package delivered. Same route as before.",
             this
             );
    }

    public string VagueBehavior()
    {
        return "Avoid details, use coded phrases.";
    }
}
