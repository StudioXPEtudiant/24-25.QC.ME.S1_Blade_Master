using UnityEngine;

public class FlipVersSouris : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Récupérer la position de la souris en coordonnées d'écran
        Vector3 positionSourisEcran = Input.mousePosition;

        // Convertir la position de la souris en coordonnées du monde
        Vector3 positionSourisMonde = Camera.main.ScreenToWorldPoint(positionSourisEcran);

        // Garder les coordonnées Z intactes pour les jeux 2D
        positionSourisMonde.z = 0f;

        // Calculer la direction de la souris par rapport à la position du joueur
        Vector2 direction = new Vector2(positionSourisMonde.x - transform.position.x, positionSourisMonde.y - transform.position.y);

        // Si la direction est vers la droite, ne pas flip, sinon flip
        if (direction.x >= 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
}



