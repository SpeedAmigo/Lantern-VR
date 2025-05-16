using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class LockerScirpt : MonoBehaviour
{
    [SerializeField] private int wheelsOnPosition;
    [SerializeField] Rigidbody lockerRigidbody;
    
    private void CheckWheelsOnPosition()
    {
        if (wheelsOnPosition == 4)
        {
            Debug.Log("Unlocked!");
            lockerRigidbody.useGravity = true;
        }
    }

    public void AddWheel()
    {
        if (wheelsOnPosition >= 4) return;
        wheelsOnPosition++;
        
        CheckWheelsOnPosition();
    }

    public void RemoveWheel()
    {
        if (wheelsOnPosition <= 0) return;
        wheelsOnPosition--;
    }
}
