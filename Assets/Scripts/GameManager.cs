using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("Game State")]
    public float CurrentTime = 120f;
    public bool TimerRunning = false;
    public int Money = 0;
    public int Strikes = 0;
    [Header("UI")]
    public GameObject startButton;
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
    public void ResetGame()
    {
        Money = 0;
        Strikes = 0;

        CurrentTime = 120f;
        TimerRunning = false;
        if (startButton != null)
        {
            startButton.SetActive(true);
        }
    }
    public void RetryGame()
    {
        ResetGame();
        SceneManager.LoadScene(1);
    }
}