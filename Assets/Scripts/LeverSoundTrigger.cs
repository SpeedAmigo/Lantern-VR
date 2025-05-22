using UnityEngine;

public class LeverSoundTrigger : MonoBehaviour
{
    [SerializeField] private AudioClip leverSound;
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(leverSound);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
