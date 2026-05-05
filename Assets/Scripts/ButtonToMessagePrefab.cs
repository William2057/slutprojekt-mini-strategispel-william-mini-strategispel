using UnityEngine;

public class ButtonToMessagePrefab : MonoBehaviour
{
    public RectTransform button;
    public RectTransform image;

    public void SyncPosition()
    {
        button.anchoredPosition = image.anchoredPosition;
    }
}