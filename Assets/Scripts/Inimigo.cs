using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Image img3;
    static int contador = 3;
    // Start is called before the first frame update
    void Start()
    {
        //test = GameObject.FindWithTag("Lives").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Levei uma guspada");
            contador--;
            if (contador == 2)
            {
                Debug.Log("2 vidas sobrando");
                Destroy(img1);
            }
            else if (contador == 1)
            {
                Debug.Log("1 vida sobrando");
                Destroy(img2);
            }
            else
            {
                Debug.Log("0 vidas sobrando");
                Destroy(img3);
                //Time.timeScale = 0;
            }

        }
    }
}
