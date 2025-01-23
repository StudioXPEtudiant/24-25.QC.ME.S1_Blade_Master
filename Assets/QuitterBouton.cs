using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitterBouton : MonoBehaviour
{
    public void QuitGame()
    {
 #if UNITY_EDITOR
            // Pour quitter le jeu dans l'éditeur Unity
            UnityEditor.EditorApplication.isPlaying = false;
 #else
        // Pour quitter le jeu une fois buildé
        Application.Quit();
 #endif
    }
}
