using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    [SerializeField] private DOTweenAnimation animation1;
    [SerializeField] private DOTweenAnimation animation2;
    [SerializeField] private LiftDoorScript liftDoorScript;
    
    [Button]
    public void StartLift()
    {
        animation1.DOPlay();
        animation2.DOPlay();
        liftDoorScript.CloseDoor();
    }
}
