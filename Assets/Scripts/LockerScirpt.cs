using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class LockerScirpt : MonoBehaviour
{
    [SerializeField] private List<LockerWheelScript> wheels;
    [SerializeField] private int wheelsOnPosition;
    [SerializeField] Rigidbody lockerRigidbody;
    
    public void CheckWheels(LockerWheelScript wheel)
    {
        Vector3 current = NormalizeEulerAngles(wheel.transform.localEulerAngles);
        Vector3 target1 = NormalizeEulerAngles(wheel.targetRotation[0]);
        Vector3 target2 = NormalizeEulerAngles(wheel.targetRotation[1]);
        
        Vector3 delta1 = current - target1;
        Vector3 delta2 = current - target2;
        
        if (Mathf.Abs(delta1.x) < 0.1f && Mathf.Abs(delta1.y) < 0.1f && Mathf.Abs(delta1.z) < 0.1f)
        {
            wheelsOnPosition++;
        }
        else
        {
            if (wheelsOnPosition <= 0) return;
            wheelsOnPosition--;
        }
        
        if (Mathf.Abs(delta2.x) < 0.1f && Mathf.Abs(delta2.y) < 0.1f && Mathf.Abs(delta2.z) < 0.1f)
        {
            wheelsOnPosition++;
        }
        else
        {
            if (wheelsOnPosition <= 0) return;
            wheelsOnPosition--;
        }
        
        CheckWheelsOnPosition();
    }
    
    private Vector3 NormalizeEulerAngles(Vector3 angles)
    {
        angles.x = NormalizeAngle(angles.x);
        angles.y = NormalizeAngle(angles.y);
        angles.z = NormalizeAngle(angles.z);
        return angles;
    }

    private float NormalizeAngle(float angle)
    {
        return angle > 180 ? angle - 360 : angle;
    }
    
    private void CheckWheelsOnPosition()
    {
        if (wheelsOnPosition == 4)
        {
            Debug.Log("Unlocked!");
            lockerRigidbody.useGravity = true;
        }
    }
    
}
