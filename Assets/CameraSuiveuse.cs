using UnityEngine;

public class CameraSuiveuse : MonoBehaviour
{
    public Transform joueur; // Référence au transform du joueur
    public Vector3 offset; // Décalage de la caméra par rapport au joueur
    public float vitesseLerp = 5.0f; // Vitesse d'interpolation

    void LateUpdate()
    {
        // Calculer la position de la caméra avec le décalage
        Vector3 positionCible = joueur.position + offset;

        // Interpoler la position actuelle de la caméra vers la position cible
        transform.position = Vector3.Lerp(transform.position, positionCible, vitesseLerp * Time.deltaTime);
    }
}
