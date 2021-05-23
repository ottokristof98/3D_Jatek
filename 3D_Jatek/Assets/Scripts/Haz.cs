using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haz : MonoBehaviour
{
    public int sebesseg;
    
    void Update()
    {
        transform.Translate(Vector3.forward * sebesseg * Time.deltaTime);
    }
}
