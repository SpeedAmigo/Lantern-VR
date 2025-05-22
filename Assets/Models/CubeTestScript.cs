using UnityEngine;

public class CubeTestScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //if (!other.TryGetComponent<CrowbarScript>(out var crowbar)) return;
        
        Debug.Log("Entered with" + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.TryGetComponent<CrowbarScript>(out var crowbar)) return;
        
        Debug.Log("Exited with" + other.name);
    }
}
