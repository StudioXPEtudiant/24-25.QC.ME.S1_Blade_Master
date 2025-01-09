using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damage = 10;
    [SerializeField] private int quantiteDegat;

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyHealth enemyHealth = collider.gameObject.GetComponent<EnemyHealth>();
      
        
       if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}

