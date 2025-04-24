using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CrowBarBoxScript : MonoBehaviour
{
    [SerializeField] private GameObject wholeGlass;
    [SerializeField] private GameObject brokenGlass;


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
