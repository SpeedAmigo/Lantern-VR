using Sirenix.OdinInspector;
using UnityEngine;
public class CrowBarBoxScript : MonoBehaviour
{
    [SerializeField] private GameObject wholeGlass;
    [SerializeField] private GameObject brokenGlass;
    
    [SerializeField] private float radius;
    [SerializeField] private float powerMultiplier;
    [SerializeField] private CrowbarScript crowBar;

    private void OnEnable()
    {
        EventManager.OnBreakGlass += BreakGlass;
    }

    private void OnDisable()
    {
        EventManager.OnBreakGlass -= BreakGlass;
    }

    private void BreakGlass(Vector3 hitPosition, Vector3 hitNormal, float impactForce)
    {
        CallReplace();

        Vector3 explosionPoint = hitPosition - hitNormal * 0.5f;
        
        CreateExplosion(explosionPoint, impactForce);
    }

    private void CreateExplosion(Vector3 hitPosition, float impactForce)
    {
        Collider[] hitColliders = Physics.OverlapSphere(hitPosition, radius);
        
        foreach (Collider hitCollider in hitColliders)
        {
            Rigidbody rb = hitCollider.GetComponent<Rigidbody>();
            
            if (rb != null)
            {
                rb.AddExplosionForce(impactForce * powerMultiplier, hitPosition, radius);
            }
        }

        crowBar.SetGrabbAble();
    }
    
    [Button]
    private void CallReplace()
    {
        ReplaceGlass(wholeGlass, brokenGlass);
    }

    private void ReplaceGlass(GameObject from, GameObject to)
    {
        from.SetActive(false);
        to.SetActive(true);
    }
}
