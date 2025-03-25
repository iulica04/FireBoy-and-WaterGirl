using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gemscollected;
    [SerializeField] int TotaleGems = 5; // Totalul de gemuri necesare pentru a finaliza nivelul
    private bool redDoorOpened = false;
    private bool blueDoorOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        TotaleGems = 5; // Sau orice alt număr de gemuri necesare
        Debug.Log("Nr levels: " + SceneManager.sceneCountInBuildSettings);
    }

    // Update is called once per frame
    void Update()
    {
        // Aici nu avem nevoie de logică suplimentară pentru moment
    }

    // Metoda care este apelată atunci când ușa roșie se deschide
    public void RedDoorOpened()
    {
        redDoorOpened = true;
        Debug.Log("Red Door Opened!");
        CheckLevelComplete(); // Verificăm dacă ambele uși sunt deschise
    }

    // Metoda care este apelată atunci când ușa albastră se deschide
    public void BlueDoorOpened()
    {
        blueDoorOpened = true;
        Debug.Log("Blue Door Opened!");
        CheckLevelComplete(); // Verificăm dacă ambele uși sunt deschise
    }

    // Verificăm dacă ambele uși sunt deschise și dacă toate gemele sunt colectate
    public void CheckLevelComplete()
    {
        if (redDoorOpened && blueDoorOpened) //&& gemscollected >= TotaleGems
        {
            Debug.Log("Level Completed!");
            NextLevel(); // Trecem la nivelul următor
        }
    }

    // Dacă nivelul este complet, trecem la următorul nivel
    public void NextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        currentLevel++;
        if (currentLevel >= SceneManager.sceneCountInBuildSettings) // Dacă este ultimul nivel, revenim la primul
        {
            currentLevel = 0;
        }

        SceneManager.LoadScene(currentLevel); // Încarcă nivelul următor
    }

    // Funcție pentru a reporni nivelul curent
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reîncarcă nivelul curent
    }
}
