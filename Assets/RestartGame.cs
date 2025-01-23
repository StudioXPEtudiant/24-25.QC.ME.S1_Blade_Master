using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        // Recharge la scène active
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

