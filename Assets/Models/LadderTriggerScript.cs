using UnityEngine;
using UnityEngine.Events;

public class LadderTriggerScript : MonoBehaviour
{
    [SerializeField] private UnityEvent TriggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crowbar"))
        {
            TriggerEvent.Invoke();
        }
    }
}
