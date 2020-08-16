using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class ShipController : MonoBehaviour
{
    PlayerControlls inputActions;
    [SerializeField]
    Rigidbody shipRB;

    float rotationToPerform = 0,
        thrust = 50;
    bool thrustToPerform = false;
    const float mult = 10; 
    
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
}
