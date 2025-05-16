using DG.Tweening;
using UnityEngine;

public class LockerWheelScript : MonoBehaviour
{
    [SerializeField] private LockerScirpt locker;
    public Vector3[] targetRotation;
    private float duration = 0.5f;

    private Tween rotationTween;
    
    public void StepRotateHorizontal(float stepDegrees = 36f)
    {
        if (rotationTween != null && rotationTween.IsActive() && rotationTween.IsPlaying())
            return;   
        
        rotationTween = transform.DORotate(transform.eulerAngles + new Vector3(0, stepDegrees, 0), 
            duration, 
            RotateMode.Fast)
            .SetEase(Ease.InOutSine)
            .OnComplete(() =>
            {
                rotationTween = null; 
                locker.CheckWheels(this);
            });
    }
    
    public void StepRotateVertical(float stepDegrees = 36f)
    {
        if (rotationTween != null && rotationTween.IsActive() && rotationTween.IsPlaying())
            return; 
        
        rotationTween = transform.DORotate(transform.eulerAngles + new Vector3(stepDegrees, 0, 0), 
                duration, 
                RotateMode.Fast)
            .SetEase(Ease.InOutSine)
            .OnComplete(() =>
            {
                rotationTween = null; 
                locker.CheckWheels(this);
            });
    }

}
