using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour{
    public float Velocidade = 10.0f;
    public float HorizontalAxix;
    public Rigidbody2D rigidbody;
    private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update(){
        HorizontalAxix = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(Velocidade * HorizontalAxix, 0);
    }
}
