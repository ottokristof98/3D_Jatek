using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akadaly : MonoBehaviour
{
    

    public int sebesseg;
    void Update()
    {
        transform.Translate(Vector3.forward * sebesseg * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log("");
        }
    }
}
