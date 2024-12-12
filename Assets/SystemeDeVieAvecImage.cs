using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SystemeDeVieAvecImage : MonoBehaviour
{
    public int vieMax = 3; // Vie maximale du joueur
    private int vieCourante; // Vie actuelle du joueur
    public Image[] imagesVie; // Tableau d'images représentant les vies
    public Sprite viePleine; // Sprite représentant une vie pleine
    public Sprite vieVide; // Sprite représentant une vie vide
    public GameObject boutonReessayer; // Référence au bouton à activer
    public float delay = 5f; // Temps en secondes avant de recharger la scène

    void Start()
    {
        vieCourante = vieMax;
        MettreAJourAffichageVie();
        boutonReessayer.SetActive(false); // Désactiver le bouton au départ
    }

    // Méthode pour infliger des dégâts
    public void InfligerDommage(int dommage)
    {
        vieCourante -= dommage;
        if (vieCourante < 0)
        {
            vieCourante = 0;
        }
        MettreAJourAffichageVie();

        if (vieCourante <= 0)
        {
            Mourir();
        }
    }

    // Méthode pour guérir
    public void Guerir(int montant)
    {
        vieCourante += montant;
        if (vieCourante > vieMax)
        {
            vieCourante = vieMax;
        }
        MettreAJourAffichageVie();
    }

    // Méthode pour mettre à jour l'affichage des vies
    void MettreAJourAffichageVie()
    {
        for (int i = 0; i < imagesVie.Length; i++)
        {
            if (i < vieCourante)
            {
                imagesVie[i].sprite = viePleine;
            }
            else
            {
                imagesVie[i].sprite = vieVide;
            }
        }
    }

    // Méthode pour gérer la mort
    void Mourir()
    {
        Debug.Log("Le joueur est mort !");
        boutonReessayer.SetActive(true); // Activer le bouton lorsque le joueur meurt
        //Destroy(gameObject);
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}


