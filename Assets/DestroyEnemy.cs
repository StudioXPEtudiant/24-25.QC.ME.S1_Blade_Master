using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Cette fonction est appelée lorsqu'un autre collider entre en collision avec celui-ci
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Vérifiez si l'objet entrant en collision a le tag "Projectile" ou "Player"
        if (collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("Player"))
        {
            // Détruire l'ennemi
            Destroy(gameObject);

            // Optionnel : Détruire également le projectile
            if (collision.gameObject.CompareTag("Projectile"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

