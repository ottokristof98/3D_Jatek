using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] akadalyMintak;
    private float SpawnKoztiIdo;
    public float kezdesSpawnIdo;
    public float csokkenesIdo;
    public float minIdo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnKoztiIdo <= 0){
        int rand = Random.Range(0, akadalyMintak.Length);
        Instantiate(akadalyMintak[rand], transform.position, Quaternion.identity);
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
