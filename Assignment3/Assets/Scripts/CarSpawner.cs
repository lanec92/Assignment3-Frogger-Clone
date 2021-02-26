using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    void Update ()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        GameObject clone = (GameObject) Instantiate(car, spawnPoint.position, spawnPoint.rotation);
        Destroy(clone, 3.5f);
    }
    /*
    void SpawnCar ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
        DestroyCar(spawnPoint);
    }

    void DestroyCar(Transform spawnpoint)
    {

        GameObject clone = (GameObject)Instantiate(car, spawnpoint.position, spawnpoint.rotation);
        Destroy(clone, 1.0f);
        Debug.Log("DestroyClone");
    }*/
}
