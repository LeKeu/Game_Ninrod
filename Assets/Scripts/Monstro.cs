using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monstro : MonoBehaviour
{
    //public Buttons ButtonsScript;
    private Rigidbody2D rb2D; //pego o rb do monstro

    [SerializeField] float velMonstr;
    [SerializeField] KeyCode Key;

    public static int cena;


    //private int cena;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(Key))
        {
            Debug.Log("oi");
            //mudarCena();
        }
    }

    void FixedUpdate()
    {
        rb2D.transform.Translate(0, velMonstr, 0); // movimenta o monstro p cima
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        { //se ele tocar no player, acontece tal coisa
            cena = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("monstro " + cena);
            SceneManager.LoadScene("Perder");
        }
    }
}
