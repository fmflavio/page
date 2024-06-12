using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float vel;
    public Rigidbody2D rigid;
    public Animator anin;
    public GameObject UIgameover;
    void Start(){
        Time.timeScale = 1.0f;
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if (Input.GetMouseButtonDown(0))
            rigid.velocity = Vector2.up * vel;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Obstaculo")
            GameOver();
    }
    public void GameOver() {
        anin.SetTrigger("GameOver");
        UIgameover.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void Reiniciar() {
        SceneManager.LoadScene("Main");
    }
}
