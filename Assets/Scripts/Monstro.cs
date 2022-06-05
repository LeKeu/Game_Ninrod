using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstro : MonoBehaviour
{
    private Rigidbody2D rb2D; //pego o rb do monstro

    [SerializeField] float velMonstr;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.transform.Translate(0, velMonstr, 0); // movimenta o monstro p cima
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){ //se ele tocar no player, acontece tal coisa
            Debug.Log("PEGUEI");
        }    
    }
}
