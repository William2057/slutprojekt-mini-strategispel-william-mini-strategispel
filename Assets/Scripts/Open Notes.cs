using UnityEngine;
using UnityEngine.InputSystem;

public class PopupUIController : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject imageObj;

    private bool isVisible = false;
    private bool allowClose = false;

    private bool lastPointerState = false;

    void Start()
    {
        HideAll();
    }

    void Update()
    {
        if (!isVisible || !allowClose) return;

        bool currentPointer =
            (Mouse.current != null && Mouse.current.leftButton.isPressed) ||
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.isPressed);

        // detect ONLY the moment of press (not hold/release spam)
        if (currentPointer && !lastPointerState)
        {
            HideAll();
        }

        lastPointerState = currentPointer;
    }

    public void ShowUI()
    {
        text1.SetActive(true);
        text2.SetActive(true);
        text3.SetActive(true);
        imageObj.SetActive(true);

        isVisible = true;
        allowClose = false;

        StartCoroutine(EnableCloseNextFrame());
    }

    private System.Collections.IEnumerator EnableCloseNextFrame()
    {
        yield return null; // prevents same-click reopen/close loop
        allowClose = true;
    }

    private void HideAll()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        imageObj.SetActive(false);

        isVisible = false;
        allowClose = false;
    }
}