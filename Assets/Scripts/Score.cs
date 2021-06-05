using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    static float scoreNumber = 0;

    void Update()
    {
        scoreNumber = scoreNumber + player.position.z + 45;
        scoreText.text = (scoreNumber).ToString("0");
    }
}
