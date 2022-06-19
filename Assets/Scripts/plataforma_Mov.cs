using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma_Mov : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] float velPlat;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    { //-10, +10
        rb2D.transform.Translate(velPlat, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Torre" || other.gameObject.tag == "Plataforma")
        {
            //Debug.Log("AAAAAAAAAAAAAAAAA");
            velPlat *= -1;
            //rb2D.transform.Translate(velPlat * -1, 0, 0);
        }
    }
}
