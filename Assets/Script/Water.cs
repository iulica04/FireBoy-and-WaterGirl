using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Blue") || collision.gameObject.CompareTag("Red"))
        {
            if (!gameObject.CompareTag(collision.gameObject.tag))
            {
                Debug.Log("Death");
                GameOverScreen.SetUp();
            }
        }   
        
    }
}
