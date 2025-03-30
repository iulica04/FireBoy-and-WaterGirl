using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swtich_level6 : MonoBehaviour
{
    [SerializeField] Lift2_Reverse l1;
    [SerializeField] Lift2_Reverse l2;
    [SerializeField] Lift2 l3;
    [SerializeField] Lift2 l4;
    [SerializeField] Lift1_Level4 lift1_Level4;
    [SerializeField] Bridge bridge;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (l1 != null) l1.moveLift = true;
        if (l2 != null) l2.moveLift = true;
        if (l3 != null) l3.moveLift = true;
        if (l4 != null) l4.moveLift = true;
        if (bridge != null) bridge.moveLift = true;
        if (lift1_Level4 != null) lift1_Level4.moveLift = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (l1 != null) l1.moveLift = false;
        if (l2 != null) l2.moveLift = false;
        if (l3 != null) l3.moveLift = false;
        if (l4 != null) l4.moveLift = false;
        if (bridge != null) bridge.moveLift = false;
        if (lift1_Level4 != null) lift1_Level4.moveLift = false;
    }
}
