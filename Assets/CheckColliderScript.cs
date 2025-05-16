using UnityEngine;

public class CheckColliderScript : MonoBehaviour
{
    [SerializeField] private LockerScirpt lockerScript;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<NumColliderScript>(out var numCollider)) return;
        
        lockerScript.AddWheel();
        Debug.Log("Added wheel");
    }

    private void OnTriggerExit(Collider other)
    {
        lockerScript.RemoveWheel();
        Debug.Log("Removed wheel");
    }
}
