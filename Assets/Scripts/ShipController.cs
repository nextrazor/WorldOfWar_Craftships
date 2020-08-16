using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

public class ShipController : MonoBehaviour
{
    PlayerControlls inputActions;
    ShipStats shipStats;

    [SerializeField]
    Rigidbody shipRB;
    [SerializeField]
    Slider sliderBoost;

    float rotationToPerform = 0,
        thrust = 50;

    bool thrustToPerform = false;
    bool boostToPerform = false;
    const float mult = 30; 
    
    void Start()
    {
        shipStats = new ShipStats();

        inputActions = new PlayerControlls();
        inputActions.PlayerActions.Enable();

        inputActions.PlayerActions.Rotate.performed += RotateShip;
        inputActions.PlayerActions.Thrust.started += ThrustEnabled;
        inputActions.PlayerActions.Thrust.canceled += ThrustDisabled;
        inputActions.PlayerActions.SpeedBoost.started += BoostStarted;
        inputActions.PlayerActions.SpeedBoost.canceled += BoostCanceled;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationToPerform * mult * Time.deltaTime, 0));

        if (thrustToPerform)
            shipRB.AddForce(-transform.forward * thrust);

        if (boostToPerform)
        {
            if (shipStats.changeBoost(sliderBoost, -shipStats.boostDecaySpeed * Time.deltaTime))
                thrust = 150;
            else
                thrust = 50;
        }
        else
        {
            thrust = 50;
            shipStats.changeBoost(sliderBoost, shipStats.boostDecaySpeed * Time.deltaTime);
        }
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

    void BoostStarted(CallbackContext context)
    {
        boostToPerform = true;
    }

    void BoostCanceled(CallbackContext context)
    {
        boostToPerform = false;
    }
}


public class ShipStats
{
    public float HP = 100,
        boost = 100,
        boostDecaySpeed = 20;

    public bool changeBoost(Slider slider, float change)
    {
        if (this.boost + change >= 0 && this.boost + change <= 100)
        {
            this.boost += change;
            slider.value = this.boost;
            return true;
        }
        else
            return false;
            
    }
}