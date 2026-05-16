using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackToMenu : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene(0);
    }
}