using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highScore;

    private int currentHighScore;

    private void Start()
    {
        currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        highScore.text = currentHighScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float height = player.position.y;
        int currentScore = Mathf.FloorToInt(height);

        currentScore = Mathf.Max(0, currentScore); 
        score.text = $"Score: {currentScore}";
        if (currentScore > currentHighScore)
        {
            currentHighScore = currentScore;
            highScore.text = $"HighScore: {currentHighScore}";

           // PlayerPrefs.SetInt("HighScore", currentHighScore);
           // PlayerPrefs.Save(); 
        }
    }
}
