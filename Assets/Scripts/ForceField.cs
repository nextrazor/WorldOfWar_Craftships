using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    float elapsedTime = 0;

    void Start()

    {
        
    }
     
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(elapsedTime > 3)
        {
            Destroy(gameObject);
            
        }
        else
        {
            elapsedTime += Time.deltaTime;
        }
    } 

}
