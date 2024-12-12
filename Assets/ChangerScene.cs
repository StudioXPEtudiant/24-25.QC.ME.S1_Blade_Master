using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    // Méthode pour changer de scène
    public void ChangerDeScene(string nomDeLaScene)
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}

