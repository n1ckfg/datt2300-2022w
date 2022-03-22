using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Vector3 speed;
    public Vector3 rot;

    void Start() {
        
    }

    void Update() {
        transform.Translate(speed);
        transform.Rotate(rot);
        if (transform.position.x > 1f || transform.position.x < -1f) speed.x *= -1f;
    }

}
