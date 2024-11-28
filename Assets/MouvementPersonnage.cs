using UnityEngine;

public class MouvementPersonnage : MonoBehaviour
{
    public float vitesse = 5f; // Vitesse du personnage

    private Rigidbody2D rb;
    private Vector2 mouvement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mouvement.x = Input.GetAxis("Horizontal");
        mouvement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mouvement * vitesse * Time.fixedDeltaTime);
    }
}

