using UnityEngine;
using UnityEngine.UI;

public class Boulder : MonoBehaviour
{
    public float boulderSpeed = 1f;
    public float deadzone = -15f;
    public int carPassed;
    void Start()
    {

    }

    void Update()
    {
        transform.position += (Vector3.down * boulderSpeed) * Time.deltaTime;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {

            Destroy(gameObject);
        }
    }

}
