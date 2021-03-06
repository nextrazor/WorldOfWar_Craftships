﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipResizer : MonoBehaviour
{
 const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // resizing control

    public float ScaleFactorPerSecond = 0.05f;
    int scaleFactorSignMultiplier = 1;


	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // resize the game object
        Vector3 newScale = transform.localScale;
        
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        
        transform.localScale = newScale;

        // update timer and check if it's done
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds) {

            // reset timer and start resizing the game object
            // in the opposite direction
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
	}
}