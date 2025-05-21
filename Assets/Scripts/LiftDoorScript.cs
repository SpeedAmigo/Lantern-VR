using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class LiftDoorScript : MonoBehaviour
{
    [SerializeField] private DOTweenAnimation animation1;
    [SerializeField] private DOTweenAnimation animation2;
    
    [SerializeField] private PowerManager powerManager;
    [SerializeField] private AudioSource audioSource;
    
    [Button]
    public void OpenDoor()
    {
        if (powerManager.isPowered == true)
        {
            animation1.DOPlayForward();
            animation2.DOPlayForward();
            audioSource.PlayOneShot(audioSource.clip);
        }
    }

    [Button]
    public void CloseDoor()
    {
        if (powerManager.isPowered == true)
        {
            animation1.DOPlayBackwards();
            animation2.DOPlayBackwards();
        }
    }
}
