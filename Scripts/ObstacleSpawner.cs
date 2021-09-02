using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] float spawnRate;
    float maxXpos = 2.2f;
    float minXpos = -2.2f;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float randomX = Random.Range(minXpos, maxXpos);
        int randomIndex = Random.Range(0, obstacles.Length);
        Vector2 randSpawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(obstacles[randomIndex], randSpawnPos, Quaternion.identity);
    }
   public void StartSpawning()
    {
        InvokeRepeating(nameof(Spawn), 1f, spawnRate);
    }
  public  void StopSpawning()
    {
        CancelInvoke(nameof(Spawn));
    }
}
