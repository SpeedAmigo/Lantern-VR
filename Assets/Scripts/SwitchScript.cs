using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] private GameObject onSwitch;
    [SerializeField] private GameObject offSwitch;
    
    [SerializeField][Range(1,8)] private int switchNumber;
    [SerializeField] private ControllPanelScript controllPanel;


    public void ChangeSwitch(GameObject switchObject)
    {
        if (switchObject == onSwitch)
        {
            onSwitch.SetActive(false);
            offSwitch.SetActive(true);
            controllPanel.ChangeLight(switchNumber);
        }
        else if (switchObject == offSwitch)
        {
            onSwitch.SetActive(true);
            offSwitch.SetActive(false);
            controllPanel.ChangeLight(switchNumber);
        }
    }
}
