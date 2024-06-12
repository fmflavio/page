using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour{
    public Rigidbody2D rigidbody;
    public BoxCollider2D colider;
    private void Start(){
        rigidbody = GetComponent<Rigidbody2D> ();
        colider = GetComponent<BoxCollider2D> ();
    }
    private void OnCollisionEnter2D(Collision2D collision){
        rigidbody.constraints = new RigidbodyConstraints2D();
        colider.isTrigger = true;
    }
}
