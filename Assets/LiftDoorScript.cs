using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class LiftDoorScript : MonoBehaviour
{
    [SerializeField] private DOTweenAnimation animation1;
    [SerializeField] private DOTweenAnimation animation2;
    
    [SerializeField] private PowerManager powerManager;
    
    [Button]
    public void OpenDoor()
    {
        if (powerManager.isPowered == true)
        {
            animation1.DOPlayForward();
            animation2.DOPlayForward();
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
