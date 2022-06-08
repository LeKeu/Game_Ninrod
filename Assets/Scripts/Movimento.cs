using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField] float velMov;
    [SerializeField] float forcaPulo;
    //private bool isPulando;
    private float moveVert;
    private float moveHoriz;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        //velMov = 5f;
        //forcaPulo = 10f;
        //isPulando = false;

    } // -1 (left) 0 (none) 1 (right)

    void Update()
    {
        moveHoriz = Input.GetAxisRaw("Horizontal");
        moveVert = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            //Debug.Log("pulando");
        }
    }

    void FixedUpdate() //mov horizontal
    {
        if (moveHoriz > 0.1f || moveHoriz < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHoriz / velMov, 0f), ForceMode2D.Impulse);
            //Debug.Log("andando");
        }
    }
}
