using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort;

public class VrHeadCollisionTest : MonoBehaviour
{
    [SerializeField] private Transform vrHeadTransform;
    [SerializeField] private Volume volume;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private float fadeSpeed = 2f;


    private Vignette vignette;
    private float targetAlpha = 0f;

    private void Awake()
    {
        if (volume != null && volume.profile.TryGet(out vignette))
        {
            vignette.active = true;
        }   
        else
        {
            Debug.Log("no vignette found in your profile");
        }
    }


    void Update()
    {
        if (Physics.CheckSphere(vrHeadTransform.position, 0.1f, wallLayer))
        {
            targetAlpha = 1f;
        }
        else
        {
            targetAlpha = 0f;
        }

        if (vignette != null)
        {
            vignette.intensity.value = Mathf.Lerp(vignette.intensity.value, targetAlpha, Time.deltaTime * fadeSpeed);
        }
    }
}
