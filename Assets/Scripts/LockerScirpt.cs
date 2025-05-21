using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class LockerScirpt : MonoBehaviour
{
    [SerializeField] private int wheelsOnPosition;
    [SerializeField] private Rigidbody lockerRigidbody;
    [SerializeField] private Rigidbody torusRigidbody;
    
    [SerializeField] private AudioClip openSound;
    private AudioSource audioSource;
    
    [SerializeField] private UnityEvent onAllWheelsOnPosition;
    
    private void CheckWheelsOnPosition()
    {
        if (wheelsOnPosition == 4)
        {
            lockerRigidbody.useGravity = true;
            torusRigidbody.useGravity = true;
            torusRigidbody.isKinematic = false;
            
            audioSource.PlayOneShot(openSound);
            onAllWheelsOnPosition?.Invoke();
        }
    }

    public void AddWheel()
    {
        if (wheelsOnPosition >= 4) return;
        wheelsOnPosition++;
        
        CheckWheelsOnPosition();
    }

    public void RemoveWheel()
    {
        if (wheelsOnPosition <= 0) return;
        wheelsOnPosition--;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
