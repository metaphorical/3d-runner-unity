using UnityEngine;
using UnityEngine.SceneManagement;
// This is the script managing global game events
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 2f;
    public GameObject CompleteLevelUI;

    static int Lives = 3;

    // GAME OVER script
    public void EndLife () 
    {
        if(!GameHasEnded){
            GameHasEnded = true;
            Lives--;
            if(Lives!=0)
            {
            // Invoke to delay by RestartDelay seconds
                Invoke("Restart", RestartDelay);
            } else {
                Debug.Log("GAME OVER");
            }
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
    
    public int GetLives()
    {
        return Lives;
    }
}
