using UnityEngine;

public class LiftParentScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.SetParent(transform);   
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.SetParent(null);
    }
}
