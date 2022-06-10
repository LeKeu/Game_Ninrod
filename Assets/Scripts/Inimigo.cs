using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    
    static int contador = 3;
  
    private Rigidbody2D rb;
    [SerializeField] float velGuspe;
    //[SerializeField] Transform barreira_topo;

    Vector2 barreira_topo;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, velGuspe);
        //limites_tela = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        barreira_topo = barreira.barreiraTeste;
        if(transform.position.y > barreira_topo.y){
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Levei uma guspada");
            contador--;
            if (contador == 2)
            {
                Debug.Log("2 vidas sobrando");
                //Destroy(imagem1); IMPORTANTE
            }
            else if (contador == 1)
            {
                Debug.Log("1 vida sobrando");
                //Destroy(imagem2); IMPORTANTE
            }
            else
            {
                Debug.Log("0 vidas sobrando");
                //Destroy(imagem3); IMPORTANTE
                //Time.timeScale = 0;
            }

        }
    }
}
