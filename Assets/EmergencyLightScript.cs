using UnityEngine;
using UnityEngine.Serialization;

public class EmergencyLightScript : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] Light light;

    [SerializeField] private Color emergencyColor;
    [SerializeField] private Color normalColor;

    [SerializeField] private Light globalLight;
    
    public void SwitchEmergencyLight(bool on)
    {
        Material material = meshRenderer.material;
        
        Color targetColor = on ? normalColor : emergencyColor;

        material.color = targetColor;
        material.SetColor("_EmissionColor", targetColor * 100);
        material.EnableKeyword("_EMISSION");
        
        light.color = targetColor;

        if (on)
        {
            globalLight.enabled = true;
        }
        else
        {
            globalLight.enabled = false;
        }
    }

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
