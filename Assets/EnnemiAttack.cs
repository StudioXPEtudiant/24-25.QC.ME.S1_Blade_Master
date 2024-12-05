using UnityEngine;

public class EnnemiAttack : MonoBehaviour
{
    public int vieMax = 50; // Vie maximale de l'ennemi
    private int vieCourante; // Vie actuelle de l'ennemi

    void Start()
    {
        vieCourante = vieMax;
    }

    // Méthode pour prendre des dégâts
    public void PrendreDegats(int degats)
    {
        vieCourante -= degats;

        if (vieCourante <= 0)
        {
            Mourir();
        }
    }

    // Méthode pour gérer la mort de l'ennemi
    void Mourir()
    {
        Debug.Log("L'ennemi est mort !");
        Destroy(gameObject);
    }
}

