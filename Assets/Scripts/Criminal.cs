using UnityEngine;
public class Criminal : Person
{
    public string Specialty;
    private static string[] possibleJobs =
    {
        "Import Coordinator",
        "Freight Dispatcher",
        "Warehouse Supervisor",
        "Shipping Consultant",
        "Private Contractor",
        "Logistics Manager",
        "Cargo Handler",
        "Sales Representative",
        "Night Shift Supervisor",
        "Transport Specialist"
    };
    public Criminal(string name, int age, string location, string id, string specialty)
        : base(
            name,
            age,
            possibleJobs[Random.Range(0, possibleJobs.Length)],
            location,
            id)
    {
        Specialty = specialty;
        CriminalRecord.Add("Drug smuggling");
        CriminalRecord.Add("Identity fraud");
    }
    public override Message GenerateMessage()
    {
        return new Message(
            "Package confirmed. Same route. No deviations.",
            this
        );
    }
    public override bool IsIllegal()
    {
        return true;
    }
    public override int GetRiskLevel()
    {
        return 100;
    }
    public string VagueBehavior()
    {
        return "Avoid details, use coded phrases.";
    }
}