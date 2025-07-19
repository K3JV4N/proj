using UnityEngine;

public class bikeSpawner : MonoBehaviour
{
    public GameObject Biker;
    public float spawnRate;
    private float timer;
    public float spawnrateIncrease;
    public float minSpawnRate;
    public float sideOffset;

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

            // Öka spawnraten (minska spawnintervall)
            spawnRate -= spawnrateIncrease;

            if (spawnRate < minSpawnRate)
            {
                spawnRate = minSpawnRate;
            }
        }
    }

    void spawnBike()
    {
        float spawnXPosition = Random.Range(0f, 1f) > 0.5f ? -sideOffset : Screen.width + sideOffset;

        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector3(spawnXPosition, Random.Range(0, Screen.height), 0));

        spawnPosition.z = transform.position.z;

        Instantiate(Biker, spawnPosition, Quaternion.identity);
    }
}
