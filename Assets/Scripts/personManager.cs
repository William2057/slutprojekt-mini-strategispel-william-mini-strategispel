using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI OtherText;

    private Person currentPerson;

    void Start()
    {
        GenerateRandomPerson();
        DisplayPersonInfo();
    }

    void GenerateRandomPerson()
    {
        List<Person> people = new List<Person>();

        people.Add(new Journalist(
            "Sarah Cole",
            34,
            "New York",
            "JR-4431"
        ));

        people.Add(new Criminal(
            "Victor Kane",
            41,
            "Chicago",
            "CR-8821",
            "Forgery"
        ));

        people.Add(new FamilyMember(
            "Emily Hart",
            28,
            "Boston",
            "FM-2201"
        ));

        int randomIndex = Random.Range(0, people.Count);

        currentPerson = people[randomIndex];
    }

    void DisplayPersonInfo()
    {
        Message msg = currentPerson.GenerateMessage();

        infoText.text =
            "PERSON RECORD\n\n" +
            "• Name: " + currentPerson.Name + "\n" +
            "• Age: " + currentPerson.Age + "\n" +
            "• Occupation: " + currentPerson.Work + "\n" +
            "• Location: " + currentPerson.Location + "\n" +
            "• ID Number: " + currentPerson.ID + "\n" +
            "• Risk Level: " + currentPerson.GetRiskLevel();
        messageText.text =
            "MESSAGE LOG\n\n" +
            "• " + msg.Text;
        OtherText.text =
            "SECURITY STATUS\n\n" +
            "Awaiting Decision...";
    }
    public void ApprovePerson()
    {
        bool illegal = currentPerson.IsIllegal();
        if (!illegal)
        {
            GameManager.Instance.AddMoney(100);
            OtherText.text = "Correct Decision!";
        }
        else
        {
            GameManager.Instance.AddStrike();
            OtherText.text = "Wrong Decision!";
        }
        ReturnToMainScene();
    }
    public void BlockPerson()
    {
        bool illegal = currentPerson.IsIllegal();
        if (illegal)
        {
            GameManager.Instance.AddMoney(100);
            OtherText.text = "Correct Decision!";
        }
        else
        {
            GameManager.Instance.AddStrike();
            OtherText.text = "Wrong Decision!";
        }
        ReturnToMainScene();
    }
    public void SendToPolice()
    {
        ReturnToMainScene();
    }
    void ReturnToMainScene()
    {
        SceneManager.LoadScene(0);
    }
}