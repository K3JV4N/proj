using UnityEngine;

public class boulder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float boulderSpeed = 1f; 
    public float deadzone = -10f; 
    public int carPassed; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * boulderSpeed) * Time.deltaTime; 



        if (transform.position.y < deadzone)
        {
            carPassed++;
        //    Debug.Log("Boulder passed car " + carPassed);
          //  Debug.Log("Boulder deleted ");
            Destroy(gameObject);
        }


    }
}
