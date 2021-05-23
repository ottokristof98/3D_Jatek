using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampaSpawner : MonoBehaviour
{
    
    public GameObject[] lampaMintak;
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
        
        int rand2 = Random.Range(0, lampaMintak.Length);
        
        Instantiate(lampaMintak[rand2], transform.position, Quaternion.identity);
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
