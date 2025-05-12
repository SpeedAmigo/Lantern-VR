using UnityEngine;
using UnityEngine.Serialization;

public class PowerManager : MonoBehaviour
{
    public bool isPowered = false;

    public void TogglePower()
    {
        isPowered = !isPowered;
    }

    public void PowerOn()
    {
        isPowered = true;
    }

    public void PowerOff()
    {
        isPowered = false;
    }
}
