using UnityEngine;

public class bikeSpawner : MonoBehaviour
{
    public GameObject Biker;
    public float spawnRate;
    private float timer;
    public float spawnrateIncrease;
    public float minSpawnRate;
    public float sideOffset;        
    public float Biker_yPosition;    

    void Start()
    {
        spawnBike();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBike();
            timer = 0;

            spawnRate -= spawnrateIncrease;
            if (spawnRate < minSpawnRate)
            {
                spawnRate = minSpawnRate;
            }
        }
    }

    void spawnBike()
    {
        float Biker_xPosition = Random.Range(0f, 1f) > 0.5f ? -sideOffset : sideOffset;

        Vector3 spawnPosition = new Vector3(Biker_xPosition, Biker_yPosition, transform.position.z);

        Instantiate(Biker, spawnPosition, Quaternion.identity);
    }
}
