using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField] float velGuspe;
    //[SerializeField] Transform barreira_topo;
    Vector2 barreira_topo;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, velGuspe);
        //vidas_script = gameObject.GetComponent<Vidas>();
    }

    // Update is called once per frame
    void Update()
    {
        barreira_topo = barreira.barreiraTeste;
        if(transform.position.y > barreira_topo.y + 10){
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Levei uma guspada");
            //vidas_script.destruir_coracao();

        }
    }
}
