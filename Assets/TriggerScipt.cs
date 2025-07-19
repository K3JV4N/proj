using UnityEngine;
using UnityEngine.UI;

public class TriggerScipt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Text carPassedText;
    public int carPassed;
    public int score;

    void Start()
    {

        carPassed = 0;
        score = 0;
    }



    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            carPassed++;

            score = carPassed / 2;

            if (carPassedText != null)
            {
                carPassedText.text = score.ToString();

            }

        }

        if (score >= 200)
        {
            //SCENEMANAGER.LoadScene("GameOverScene");
            Debug.Log("You win!");
        }




    }

}
