using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class barreira : MonoBehaviour
{
    //public Buttons ButtonsScript;
    private Rigidbody2D rb2D; //pego o rb do monstro

    [SerializeField] float vel;
    [SerializeField] Rigidbody2D jogador;

    public static Vector2 barreiraTeste;

    //private int cena;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        barreiraTeste = rb2D.position;
    }

    void FixedUpdate()
    {
        rb2D.transform.Translate(0, vel, 0); // movimenta o monstro p cima
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        { //se ele tocar no player, acontece tal coisa
            Debug.Log("entrou");
            jogador.AddForce(Vector2.down * 15, ForceMode2D.Impulse);
        }
    }
}
