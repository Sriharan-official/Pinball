using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
	
	public GameObject pinball;
	public int springForce = 1200;
    

	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject == pinball)
		{
			pinball.GetComponent<Rigidbody>().AddExplosionForce(springForce, transform.position, 1);
		}
	}
}


