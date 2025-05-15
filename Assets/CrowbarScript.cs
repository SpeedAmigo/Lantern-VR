using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CrowbarScript : MonoBehaviour
{
    private Rigidbody rb;
    private XRGrabInteractable grabAbble;

    public void SetGrabbAble()
    {
        rb.isKinematic = false;
        grabAbble.enabled = true;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        grabAbble = GetComponent<XRGrabInteractable>();
    }
}
