using DG.Tweening;
using UnityEngine;

public class LockerWheelScript : MonoBehaviour
{
    [SerializeField] private LockerScirpt locker;
    public Vector3 targetRotation;
    private float duration = 0.5f;
    
    public void StepRotateHorizontal(float stepDegrees = 36f)
    {
        transform.DORotate(transform.eulerAngles + new Vector3(0, stepDegrees, 0), 
            duration, 
            RotateMode.Fast).SetEase(Ease.InOutSine).OnComplete(() => locker.CheckWheels(this));
        
    }
    
    public void StepRotateVertical(float stepDegrees = 36f)
    {
        transform.DORotate(transform.eulerAngles + new Vector3(stepDegrees, 0, 0),
            duration,
            RotateMode.Fast).SetEase(Ease.InOutSine).OnComplete(() => locker.CheckWheels(this));
    }

}
