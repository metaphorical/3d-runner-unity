using UnityEngine;
using UnityEngine.SceneManagement;
// This is the script managing global game events
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 2f;
    public GameObject CompleteLevelUI;

    // GAME OVER script
    public void EndGame () 
    {
        if(!GameHasEnded){
            GameHasEnded = true;
            // Invoke to delay by RestartDelay seconds
            Invoke("Restart", RestartDelay);
        }
    }
    // Restarting current scene (level)
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Method ot complete the level
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
}
