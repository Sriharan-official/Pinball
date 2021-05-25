using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
    public int springForce;
    public GameObject pinball;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            pinball.GetComponent<Rigidbody>().AddExplosionForce(springForce * 10000, transform.position, 1);
        }
    }
}
