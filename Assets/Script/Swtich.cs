using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swtich : MonoBehaviour
{
 
    [SerializeField] private Lift_For_Swtich_Y[] liftsY; // Lifturi care se mișcă pe Y
    [SerializeField] private Lift_For_Swtich_X[] liftsX; // Lifturi care se mișcă pe X
    [SerializeField] private Bridge b;

    private void OnTriggerStay2D(Collider2D collision)
    {

        // Activează toate lifturile pe Y
        foreach (var lift in liftsY)
        {
            if (lift != null) lift.moveLift = true;
        }

        // Activează toate lifturile pe X
        foreach (var lift in liftsX)
        {
            if (lift != null) lift.moveLift = true;
        }

        if (b != null) b.moveLift = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        // Dezactivează toate lifturile pe Y
        foreach (var lift in liftsY)
        {
            if (lift != null) lift.moveLift = false;
        }

        // Dezactivează toate lifturile pe X
        foreach (var lift in liftsX)
        {
            if (lift != null) lift.moveLift = false;
        }

        if (b != null) b.moveLift = false;
    }
}
