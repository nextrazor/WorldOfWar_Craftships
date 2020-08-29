using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float impulse = 10f;
    public Rigidbody body;
    void Start()
    {
        body.AddForce(transform.forward * impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
