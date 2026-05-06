using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public void changeScene()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(0);
    }
}
