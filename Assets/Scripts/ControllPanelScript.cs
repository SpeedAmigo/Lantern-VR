using NUnit.Framework;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

public class ControllPanelScript : SerializedMonoBehaviour
{
    [SerializeField] private List<MeshRenderer> lightBulbs;
    public Dictionary<int, List<GameObject>> switches;

    [SerializeField] Material offMaterial;
    [SerializeField] Material onMaterial;
    
    [SerializeField] private LightBulbSocketScript lightBulbSocketScript;
    [SerializeField] private UnityEvent onAllPluggedIn;
    
    public void ChangeLight(int value)
    {
        var bulbs = switches[value];
        
        foreach (var bulb in bulbs)
        {
           var renderer = bulb.GetComponent<MeshRenderer>();

           renderer.material = ToggleMaterial(renderer.sharedMaterial);
        }

        CheckForComplete(lightBulbs);
    }

    private Material ToggleMaterial(Material material)
    {
        if (material == null) return null;

        if (material == offMaterial)
        {
            return onMaterial;
        }
        else if (material == onMaterial)
        {
            return offMaterial;
        }

        return null;
    }

    private void CheckForComplete(List<MeshRenderer> bulbsMaterials)
    {
        if (bulbsMaterials.All(bulb => bulb.sharedMaterial == onMaterial))
        {
            if (lightBulbSocketScript.hasLightBulb)
            {
                onAllPluggedIn?.Invoke();
            }
        }
    }
}
