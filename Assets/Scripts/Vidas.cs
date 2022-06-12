using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    private Rigidbody2D rb;
    public int vida;
    public int numDeVidas;
    public Image[] vidas;
    public static int cena;
    [SerializeField] float segFreeze;
    Renderer rend;
    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < vidas.Length; i++)
        {
            if (i < numDeVidas)
            {
                vidas[i].enabled = true;
            }
            else
            {
                vidas[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            Freeze_Teste();
            numDeVidas--;
            Debug.Log("Num de vidas = " + numDeVidas);
            if (numDeVidas == 0)
            {
                Debug.Log("GAME OVER");
                cena = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene("Perder");
            }
            else
            {
                Debug.Log("ENTROU VIDAS SCRIPT");
                Destroy(other.gameObject);
            }

        }
        if (other.gameObject.tag == "Monster")
        {
            cena = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("Perder");
        }
    }

    public void Freeze_Teste()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        rend.material.color = Color.black;
        Invoke("Unfreeze_teste", segFreeze);
    }

    void Unfreeze_teste()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rend.material.color = Color.white;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Plataforma")
        {
            cena = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("Perder");
        }
    }
}
