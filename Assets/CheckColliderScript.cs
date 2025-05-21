using UnityEngine;

public class CheckColliderScript : MonoBehaviour
{
    [SerializeField] private LockerScirpt lockerScript;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<NumColliderScript>(out var numCollider)) return;
        
        lockerScript.AddWheel();
    }

    private void OnTriggerExit(Collider other)
    {
        lockerScript.RemoveWheel();
    }
}
