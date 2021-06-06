using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text livesText;
    static float scoreNumber = 0;

    void Update()
    {
        scoreNumber = scoreNumber + player.position.z + 45;
        scoreText.text = (scoreNumber).ToString("0");

        livesText.text = "Lives:" + FindObjectOfType<GameManager>().GetLives().ToString("0");
    }
}
