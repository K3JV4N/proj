using UnityEngine;

public class boulder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float boulderSpeed = 1f; // Speed at which the boulder moves down   
    public float deadzone = -10f; // The y-coordinate below which the boulder is destroyed
    public int carPassed; // Counter for how many times the boulder has been hit
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * boulderSpeed) * Time.deltaTime; // Moves the boulder down at a speed of 5 units per second



        if (transform.position.y < deadzone)
        {
            carPassed++;
            Debug.Log("Boulder passed car " + carPassed);
            Debug.Log("Boulder deleted ");
            Destroy(gameObject);
        }





    }
}
