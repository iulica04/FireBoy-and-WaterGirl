using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoor : MonoBehaviour
{
    public GameObject RedDoorObject;
    public GameObject OpenRedDoor;
    [SerializeField] GameManager gm;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            RedDoorObject.SetActive(false);
            OpenRedDoor.SetActive(true);
            gm.RedDoorOpened();
        }
    }
}
