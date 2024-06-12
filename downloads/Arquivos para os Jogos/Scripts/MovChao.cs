using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovChao : MonoBehaviour{
    public float vel;
    void Update() {
        transform.Translate(vel * Time.deltaTime * Vector2.left);
        if(transform.position.x < -27.30f) 
            transform.position = new Vector2(27.30f, -3);
    }
}
