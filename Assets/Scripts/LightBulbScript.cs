using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class LightBulbScript : MonoBehaviour
{
    private Rigidbody _rb;
    private XRGrabInteractable grabAbble;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<LightBulbSocketScript>(out var socket))
        {
            if (socket.doorUnclocked == false) return;
            
            _rb.isKinematic = true;
            transform.position = socket.socketTransform.position;
            transform.rotation = socket.socketTransform.rotation;      
            socket.hasLightBulb = true;
            grabAbble.enabled = false;
        }
    }
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        grabAbble = GetComponent<XRGrabInteractable>();
    }
}
