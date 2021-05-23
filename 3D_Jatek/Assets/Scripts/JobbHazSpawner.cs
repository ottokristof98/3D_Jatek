using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobbHazSpawner : MonoBehaviour
{
   public GameObject[] jobbhazMintak;
    private float SpawnKoztiIdo;
    public float kezdesSpawnIdo;
    public float csokkenesIdo;
    public float minIdo;
    void Update()
    {
        if(SpawnKoztiIdo <= 0){
        
        int rand = Random.Range(0, jobbhazMintak.Length);
        
        Instantiate(jobbhazMintak[rand], transform.position, Quaternion.identity);
        SpawnKoztiIdo = kezdesSpawnIdo;
        if(kezdesSpawnIdo > minIdo)
        {
            kezdesSpawnIdo -= csokkenesIdo;
        }
        }else{
            SpawnKoztiIdo -= Time.deltaTime; 
        }
    }
}
