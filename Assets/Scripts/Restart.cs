using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
            
    }
}
