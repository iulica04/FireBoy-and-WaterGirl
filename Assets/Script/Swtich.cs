using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swtich : MonoBehaviour
{
    [SerializeField] Lift2 l;
    [SerializeField] Lift1_Level4 l1;
    [SerializeField] Up l2;
    [SerializeField] Bridge b;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(l!=null)
            l.moveLift = true;
        if (b != null)
            b.moveLift = true;
        if (l1 != null)
            l1.moveLift = true;
        if (l2 != null)
            l2.moveLift = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (l != null)
            l.moveLift = false;
        if (b != null)
            b.moveLift = false;
        if (l1 != null)
            l1.moveLift = false;
        if (l2 != null)
            l2.moveLift = false;
    }
}
