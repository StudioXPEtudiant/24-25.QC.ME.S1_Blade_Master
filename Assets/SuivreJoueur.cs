using System;
using Unity.VisualScripting;
using UnityEngine;

public class SuivreJoueur : MonoBehaviour
{
    public Transform joueur; // Référence au joueur
    public float vitesse = 2.0f; // Vitesse de suivi

    void Awake()
    {
        joueur = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (joueur != null)
        {
            // Calculer la direction vers le joueur
            Vector2 direction = (joueur.position - transform.position).normalized;
            
            // Déplacer l'objet vers le joueur
            transform.position = Vector2.MoveTowards(transform.position, joueur.position, vitesse * Time.deltaTime);
        }
    }
}

