using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jatekos : MonoBehaviour
{
    public float sebesseg;
    public float maxX;
    public float minX;
    public float Xvalt;
    private Vector3 cel;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cel, sebesseg * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
        {
                cel = new Vector3(transform.position.x + Xvalt, transform.position.y, transform.position.z);
        }else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
        {
                cel = new Vector3(transform.position.x - Xvalt, transform.position.y, transform.position.z);
        }

    }
}
