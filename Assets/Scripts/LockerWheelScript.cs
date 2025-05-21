using System;
using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class LockerWheelScript : MonoBehaviour
{
    [SerializeField] private AudioClip rotateSound;
    private AudioSource audioSource;
    private float duration = 0.5f;
    private Tween rotationTween;
    
    public void StepRotateHorizontal(float stepDegrees = 36f)
    {
        if (rotationTween != null && rotationTween.IsActive() && rotationTween.IsPlaying())
            return;   
        
        audioSource.PlayOneShot(rotateSound);
        
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(0f, stepDegrees, 0f);
        
        rotationTween = transform.DORotateQuaternion(targetRotation, duration)
            .SetEase(Ease.InOutSine)
            .OnComplete(() =>
            {
                rotationTween = null; 
            });
    }
    
    public void StepRotateVertical(float stepDegrees = 36f)
    {
        if (rotationTween != null && rotationTween.IsActive() && rotationTween.IsPlaying())
            return; 
        
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(stepDegrees, 0f, 0f);
        
        rotationTween = transform.DORotateQuaternion(targetRotation, duration)
            .SetEase(Ease.InOutSine)
            .OnComplete(() =>
            {
                rotationTween = null; 
            });
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
