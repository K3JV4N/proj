using UnityEngine;

public class BikerScript : MonoBehaviour
{

    public float bikerSpeed ;
    public float deadzone;
    

    void Start()
    {
        transform.position += (Vector3.down * bikerSpeed) * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {

            Destroy(gameObject);
        }
    }


}

