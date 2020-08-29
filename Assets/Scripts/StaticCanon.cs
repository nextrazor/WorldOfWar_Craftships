using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCanon : MonoBehaviour
{
    public float elapsedtime = 0;
    public float totaltime = 1;
    public GameObject cannonball;
    public GameObject canon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedtime > 2)
        {
            GameObject firedBall = Instantiate(cannonball, canon.transform.position, canon.transform.rotation);
            elapsedtime = 0;
        }
        else
        {
            elapsedtime += Time.deltaTime;
        }
    }
}