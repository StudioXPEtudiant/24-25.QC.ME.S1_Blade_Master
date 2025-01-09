using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Fonction pour infliger des dégâts
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
       

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Fonction pour gérer la mort de l'ennemi
    void Die()
    {
        // Vous pouvez ajouter des animations de mort, des effets visuels, etc.
        Destroy(gameObject);
    }
}

