using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D playerRigidbody;
    public int playerCoorinateX;
    public int playerCoorinateY;
    public float rotationSpeed = 50f; // Speed at which the player rotates
    public float speed = 10f; // Speed at which the player moves can be adjusted in the inspector
    float rotationAngle = 90f;
    void Start()
    {
    }

    void Update()
    {


        float moveX = 0;
        float moveY = 0;

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W))
        {
            moveX = -speed;
            rotationAngle = 180f;
            rotationSpeed = rotationSpeed + 25f; // Increase the rotation speed when moving left

       while (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
            {
                rotationAngle = 135f;
            }

        }

        else if (Input.GetKey(KeyCode.D))

        {

            moveX = speed;
            rotationAngle = 45f;
            rotationSpeed = rotationSpeed + 25f; // Increase the rotation speed when moving right

            if (Input.GetKey(KeyCode.W))
            {
                rotationAngle = 90f;
            }
        }
        else
        {
            rotationAngle = 90f;
        }




        if (Input.GetKey(KeyCode.W))
        {
            moveY = speed;
        }
        else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            moveY = -speed;
        }



        Quaternion targetRotation = Quaternion.Euler(0, 0, rotationAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        playerRigidbody.linearVelocity = new Vector2(moveX, moveY);



    }

}