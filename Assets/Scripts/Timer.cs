using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI timerText;
    void Update()
    {
        if (GameManager.Instance == null)
            return;
        UpdateTimerUI();
        if (GameManager.Instance.GameEnded)
            return;
        if (GameManager.Instance.Strikes >= 3)
        {
            GameManager.Instance.GameEnded = true;
            SceneManager.LoadScene(2);
            return;
        }
        if (GameManager.Instance.TimerRunning)
        {
            GameManager.Instance.CurrentTime -= Time.deltaTime;

            if (GameManager.Instance.CurrentTime <= 0)
            {
                GameManager.Instance.CurrentTime = 0;
                GameManager.Instance.TimerRunning = false;
                GameManager.Instance.GameEnded = true;

                CheckEndConditions();
            }
        }
    }
    void UpdateTimerUI()
    {
        if (timerText == null)
            return;

        int minutes = Mathf.FloorToInt(GameManager.Instance.CurrentTime / 60);
        int seconds = Mathf.FloorToInt(GameManager.Instance.CurrentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void CheckEndConditions()
    {
        if (GameManager.Instance.Money >= 800)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}