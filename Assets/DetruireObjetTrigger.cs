using System;
using UnityEngine;

public class DetruireObjetTrigger : MonoBehaviour
{
    public float delaiDestruction = 0.0f; // Délai en secondes avant la destruction

    private void Start()
    {
        Destroy(gameObject, delaiDestruction);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifiez si l'objet avec lequel il y a collision a un tag spécifique (par exemple, "Trigger")
        if (collision.CompareTag("Trigger"))
        {
            // Détruisez l'objet actuel (le GameObject auquel ce script est attaché) après un délai
            Destroy(gameObject, delaiDestruction);
        }
    }
}

