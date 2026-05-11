using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int Money = 0;
    public int Strikes = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(int amount)
    {
        Money += amount;
    }

    public void AddStrike()
    {
        Strikes = Mathf.Min(Strikes + 1, 3);
    }
}