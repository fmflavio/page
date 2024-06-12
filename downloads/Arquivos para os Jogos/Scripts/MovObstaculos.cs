using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovObstaculos : MonoBehaviour {
    public float vel;
    public int pontuacao = 0;
    public Text textoPontuacao;
    void Update(){
        if (transform.position.x < -7) {
            transform.position = new Vector2(3.0f, Random.Range(-2.5f, -2.5f));
            pontuacao++;
            textoPontuacao.text = pontuacao.ToString();
        }
        transform.Translate(vel * Time.deltaTime * Vector2.left);
    }
}
