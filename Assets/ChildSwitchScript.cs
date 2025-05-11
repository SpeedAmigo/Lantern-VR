using UnityEngine;

public class ChildSwitchScript : MonoBehaviour
{
    [SerializeField] private SwitchScript parentSwitch;
    
    public void ChangeSwitch(GameObject switchObject)
    {
        parentSwitch.ChangeSwitch(switchObject);
    }
}
