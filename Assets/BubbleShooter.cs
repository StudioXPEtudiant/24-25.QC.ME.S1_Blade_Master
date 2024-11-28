using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    public GameObject bubblePrefab;
    public Transform shootPoint;
    public float shootForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        GameObject bubble = Instantiate(bubblePrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.right * shootForce, ForceMode2D.Impulse);
    }
}

