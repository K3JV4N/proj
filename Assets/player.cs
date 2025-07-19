using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float speed = 10f;
    private float rotationAngle = 90f;
    public int lives;

    public TriggerScript triggerScript;

    void Update()
    {
        Vector2 moveDirection = Vector2.zero;

        bool w = Input.GetKey(KeyCode.W);
        bool a = Input.GetKey(KeyCode.A);
        bool s = Input.GetKey(KeyCode.S);
        bool d = Input.GetKey(KeyCode.D);

        if (w && a && !s && !d)
        {
            moveDirection = new Vector2(-1, 1).normalized;
            rotationAngle = 135f;
        }
        else if (w && d && !s && !a)
        {
            moveDirection = new Vector2(1, 1).normalized;
            rotationAngle = 45f;
        }
        else if (s && a && !w && !d)
        {
            moveDirection = new Vector2(-1, -1).normalized;
            rotationAngle = 225f;
        }
        else if (s && d && !w && !a)
        {
            moveDirection = new Vector2(1, -1).normalized;
            rotationAngle = 315f;
        }
        else if (w && !a && !s && !d)
        {
            moveDirection = Vector2.up;
            rotationAngle = 90f;
        }
        else if (s && !w && !a && !d)
        {
            moveDirection = Vector2.down;
            rotationAngle = 270f;
        }
        else if (a && !w && !s && !d)
        {
            moveDirection = Vector2.left;
            rotationAngle = 180f;
        }
        else if (d && !w && !s && !a)
        {
            moveDirection = Vector2.right;
            rotationAngle = 0f;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
        playerRigidbody.linearVelocity = moveDirection * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7) // boulder
        {
            //Debug.Log("Player hit by boulder");
            lives--;
            // Debug.Log("Lives left: " + lives);


            if (lives <= 0)
            {
                Debug.Log("Game Over INSER GAMEOVER SCENE HERE");
                LoadScene();
            }
        }

        if (collision.gameObject.layer == 10) // biker
        {
            //Debug.Log("DONT TOUCH THE BIKER");

            if (triggerScript != null)
            {
                triggerScript.score -= 5;
                triggerScript.UpdateScore();
            }
            else
            {
                Debug.LogWarning("TriggerScript is not assigned in player script.");
            }
        }
    }

    public void LoadScene()
    {
        Debug.Log("Scene loaded");
        Invoke("ReloadScene", 1f); // delay for effect
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
