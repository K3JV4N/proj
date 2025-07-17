using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject boulder;
    public float spawnRate = 4f;
    private float timer = 0;

    public float widthOffset = 10f; 
    void Start()
    {
        spawnBoulder();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnBoulder();
            timer = 0;
        }

    }
    void spawnBoulder()
    {
        float lowerstPoint = transform.position.x - widthOffset;
        float highestPoint = transform.position.x + widthOffset;
        Instantiate(boulder, new Vector3(Random.Range(lowerstPoint, highestPoint), transform.position.y, transform.position.z), transform.rotation);

    }
}
