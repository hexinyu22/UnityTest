using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 4);
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, enemies.Length);
        Instantiate(enemies[index], transform.position, transform.localRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
