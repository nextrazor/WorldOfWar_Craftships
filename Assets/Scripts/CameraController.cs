using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject playerShip;

    public int 
        scaleX = 330,
        scaleY = 300,
        scaleZ = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(playerShip.transform.position.x + scaleX, playerShip.transform.position.y + scaleY, playerShip.transform.position.z + scaleZ);
        gameObject.transform.LookAt(playerShip.transform);
    }
}
