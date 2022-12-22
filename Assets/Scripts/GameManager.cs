using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void exitGame()
    {
        Application.Quit();
    }

    public void newProduct()
    {
        SceneManager.LoadScene("Editor");
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
