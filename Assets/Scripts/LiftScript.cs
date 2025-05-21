using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    [SerializeField] private DOTweenAnimation animation1;
    [SerializeField] private DOTweenAnimation animation2;
    [SerializeField] private LiftDoorScript liftDoorScript;
    
    public bool canBeMoved = true;
    
    public void ChangeCanBeMoved(bool value)
    {
        canBeMoved = value;
    }
    
    [Button]
    public void StartLift()
    {
        if (!canBeMoved) return;
        animation1.DOPlay();
        animation2.DOPlay();
        if (liftDoorScript != null)
        {
            liftDoorScript.CloseDoor();
        }
    }

    public void StartLiftBackwards()
    {
        if (!canBeMoved) return;
        
        animation1.DOPlayBackwards();
        animation2.DOPlayBackwards();
    }
}
