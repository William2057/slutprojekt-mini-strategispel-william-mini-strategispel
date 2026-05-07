using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    [Header("Timer Settings")]
    public float startTime = 60f;
    [Header("Game Stats")]
    public int money = 0;
    public int failedAttempts = 0;
    [Header("UI")]
    public TextMeshProUGUI timerText;
    private float currentTime;
    private bool isRunning = true;
    void Start()
    {
        currentTime = startTime;
        UpdateTimerUI();
    }
    void Update()
    {
        if (failedAttempts >= 2)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (!isRunning)
            return;
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
            isRunning = false;
            CheckEndConditions();
        }
        UpdateTimerUI();
    }
    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void CheckEndConditions()
    {
        if (money >= 600)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    public void AddMoney(int amount)
    {
        money += amount;
    }
    public void AddFailedAttempt()
    {
        failedAttempts++;
    }
}