using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour{
    private void OnCollisionEnter2D(Collision2D collision){
        GameObject collider = collision.collider.gameObject;
        GameObject.Destroy(collider);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        GameObject.Destroy(collision.gameObject);
    } 
}
