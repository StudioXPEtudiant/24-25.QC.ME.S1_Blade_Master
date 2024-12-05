using UnityEngine;

public class GenerateurDeMonstres : MonoBehaviour
{
    public GameObject[] monstres; // Tableau de prefabs de monstres à générer
    public Transform[] pointsDeSpawn; // Tableau de points de spawn
    public float intervalleDeSpawn = 5f; // Intervalle de temps entre les spawns
    private float tempsEcoule = 0f;

    void Update()
    {
        tempsEcoule += Time.deltaTime;
        
        if (tempsEcoule >= intervalleDeSpawn)
        {
            SpawnMonstre();
            tempsEcoule = 0f;
        }
    }

    void SpawnMonstre()
    {
        // Sélectionner un monstre aléatoire et un point de spawn aléatoire
        int indexMonstre = Random.Range(0, monstres.Length);
        int indexSpawn = Random.Range(0, pointsDeSpawn.Length);
        
        // Instancier le monstre au point de spawn
        Instantiate(monstres[indexMonstre], pointsDeSpawn[indexSpawn].position, pointsDeSpawn[indexSpawn].rotation);
    }
}