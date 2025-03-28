using UnityEngine;
using UnityEngine.SceneManagement; 

public class StartGame : MonoBehaviour
{
    public void LoadLevel1()
    {
        Debug.Log("Loading Level 1");
        SceneManager.LoadScene("Level 1"); 
    }
}
