using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI strikeText;

    void Update()
    {
        moneyText.text = "Money: $" + GameManager.Instance.Money;
        strikeText.text = "Strikes: " + GameManager.Instance.Strikes + "/3";
    }
}