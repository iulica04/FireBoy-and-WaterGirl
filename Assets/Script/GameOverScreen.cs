using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void SetUp()
    {
        Debug.Log("Game Over Screen Activated!");
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        Debug.Log("Restart Button Clicked!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton()
    {
        Debug.Log("Main Menu Button Clicked!");
    }
}
