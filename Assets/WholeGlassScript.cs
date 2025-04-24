using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class WholeGlassScript : MonoBehaviour
{
    [MinValue(0f)] [SerializeField] private float hardnessLevel;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.TryGetComponent(out XRGrabInteractable interactable)) return;
        
        Rigidbody objectRb = interactable.GetComponent<Rigidbody>();
        if (objectRb == null)
        {
            Debug.LogWarning("No rigidbody detected");
            return;
        }
        
        ContactPoint contact = collision.contacts[0];
        Vector3 hitPoint = contact.point;

        if (objectRb.linearVelocity.magnitude > hardnessLevel)
        {
            float impactForce = objectRb.linearVelocity.magnitude;
            Debug.Log(impactForce);
            
            EventManager.InvokeOnBreakGlass(hitPoint, contact.normal, impactForce);
        }
    }
}
