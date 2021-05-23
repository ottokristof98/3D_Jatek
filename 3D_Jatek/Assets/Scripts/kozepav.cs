using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kozepav : MonoBehaviour
{
    public int sebesseg;
    
    void Update()
    {
        transform.Translate(Vector3.forward * sebesseg * Time.deltaTime);
    }
}
