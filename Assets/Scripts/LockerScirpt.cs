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
        Vector3 target = NormalizeEulerAngles(wheel.targetRotation);
        
        Vector3 delta = current - target;
        
        if (Mathf.Abs(delta.x) < 0.1f && Mathf.Abs(delta.y) < 0.1f && Mathf.Abs(delta.z) < 0.1f)
        {
            wheelsOnPosition++;
        }
        else
        {
            if (wheelsOnPosition >= 0) return;
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
