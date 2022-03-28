using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Renderer playerRenderer;

    public void RandomColor() {
        playerRenderer.material.color = Random.ColorHSV();
    }
}
