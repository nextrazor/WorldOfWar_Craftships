using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class ShipController : MonoBehaviour
{
    PlayerControlls inputActions;
    [SerializeField]
    Rigidbody shipRB;

    float rotationToPerform = 0;
    bool thrustToPerform = false;
    public float mult = 30,
        //waterUpForce = 5,
        thrust = 50; 

    
    void Start()
    {
        inputActions = new PlayerControlls();
        inputActions.PlayerActions.Enable();

        inputActions.PlayerActions.Rotate.performed += RotateShip;
        inputActions.PlayerActions.Thrust.started += ThrustEnabled;
        inputActions.PlayerActions.Thrust.canceled += ThrustDisabled;
    }

    void Update()
    {
        //transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        transform.Rotate(new Vector3(0, rotationToPerform * mult * Time.deltaTime, 0));

        if (thrustToPerform)
            shipRB.AddForce(-transform.forward * thrust);
    }

    void RotateShip(CallbackContext context)
    {
        rotationToPerform = context.ReadValue<Vector2>().x;
    }

    void ThrustEnabled(CallbackContext context)
    {
        thrustToPerform = true;
    }

    void ThrustDisabled(CallbackContext context)
    {
        thrustToPerform = false;
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Water")
    //        shipRB.AddForce(Vector3.up * waterUpForce);
    //}
}
