using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoor : MonoBehaviour
{
    public GameObject BlueDoorObject;
    public GameObject OpenBlueDoor;
    [SerializeField] GameManager gm;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue"))
        {
            BlueDoorObject.SetActive(false);
            OpenBlueDoor.SetActive(true);
            gm.BlueDoorOpened();
        }
    }
}
