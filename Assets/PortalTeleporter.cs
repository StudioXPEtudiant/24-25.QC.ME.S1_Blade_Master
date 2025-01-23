using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public Transform destination;
    public AudioClip teleportSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = destination.position;
            other.transform.rotation = destination.rotation;
            PlayTeleportSound();
        }
    }

    void PlayTeleportSound()
    {
        if (teleportSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(teleportSound);
        }
    }
}


