using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] private GameObject onSwitch;
    [SerializeField] private GameObject offSwitch;
    
    [SerializeField][Range(1,8)] private int switchNumber;
    [SerializeField] private ControllPanelScript controllPanel;
    
    [SerializeField] private AudioSource audioSource;
    
    [SerializeField] private AudioClip onSwitchSound;
    [SerializeField] private AudioClip offSwitchSound;


    public void ChangeSwitch(GameObject switchObject)
    {
        if (switchObject == onSwitch)
        {
            onSwitch.SetActive(false);
            offSwitch.SetActive(true);
            controllPanel.ChangeLight(switchNumber);
            audioSource.PlayOneShot(offSwitchSound);
        }
        else if (switchObject == offSwitch)
        {
            onSwitch.SetActive(true);
            offSwitch.SetActive(false);
            controllPanel.ChangeLight(switchNumber);
            audioSource.PlayOneShot(onSwitchSound);
        }
    }
}
