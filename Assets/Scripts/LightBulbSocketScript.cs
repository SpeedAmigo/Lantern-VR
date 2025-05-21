using UnityEngine;

public class LightBulbSocketScript : MonoBehaviour
{
    public Transform socketTransform;
    public bool hasLightBulb;
    
    public bool doorUnclocked;

    public void SetDoorUnclocked(bool doorUnclocked)
    {
        this.doorUnclocked = doorUnclocked;
    }
}
