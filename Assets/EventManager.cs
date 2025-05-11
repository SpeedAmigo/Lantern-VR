using System;
using UnityEngine;

public static class EventManager
{
    public static event Action<Vector3, Vector3, float> OnBreakGlass;
    public static event Action OnSwitch;
    
    public static void InvokeOnBreakGlass(Vector3 hitPoint, Vector3 hitNormal, float impactForce)
    {
        OnBreakGlass?.Invoke(hitPoint, hitNormal, impactForce);
    }

    public static void InvokeOnBreakGlass()
    {
        OnSwitch?.Invoke();
    }
}
