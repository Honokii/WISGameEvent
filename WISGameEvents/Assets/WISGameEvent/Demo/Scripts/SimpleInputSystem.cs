using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInputSystem : MonoBehaviour {

    public OnGameEvent spaceButtonPressed;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            spaceButtonPressed.Raise(new OnGameEventArgs());
        }
    }
}
