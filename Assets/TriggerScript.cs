using UnityEngine;
using UnityEngine.UI;

public class TriggerScript : MonoBehaviour
{
    public Text carPassedText;
    public int carPassed = 0;
    public int score = 0;

    void Start()
    {
        carPassed = 0;
        score = 0;
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7) // bil
        {
            carPassed++;
            //score += 1;
            score = carPassed / 2; // Båda kollisterna ger poäng fixa med TAGS? carpassed && scorecountingTrigger score +=1
            UpdateScore();
        }

        if (score >= 200)
        {
            Debug.Log("You win!");
            // SceneManager.LoadScene("GameOverScene");
        }
    }

    public void UpdateScore()
    {
        score = Mathf.Max(0, score); 
        if (carPassedText != null)
        {
            carPassedText.text = score.ToString();
        }
    }
}
