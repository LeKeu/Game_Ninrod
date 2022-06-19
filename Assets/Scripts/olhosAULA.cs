using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olhosAULA : MonoBehaviour
{
    int x;
    int y;
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Transform jogador;
    float novaPos;
    Vector3 teste;
    Vector2 movimento;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        x = Screen.width;
        y = Screen.height;
        Debug.Log("X tela --> " + x);
        Debug.Log("R = " + remap(0, -12, 12, 0, 1920));
    }

    // Update is called once per frame
    void Update()
    {
        novaPos = remap(jogador.position.x, -12, 12, 0, x);

        teste = new Vector3(novaPos, jogador.position.y + (y / 2), jogador.position.z);

        Vector3 direcao = teste - transform.position;
        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;

        rb.rotation = angulo - 90f;
        direcao.Normalize();
        movimento = direcao;
    }

    public static float remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        //posPlayer, xTelinhaEsq, xTelonaEsq, xTelinhaDir, xTelonaDir 
        var fromAbs = from - fromMin;
        var fromMaxAbs = fromMax - fromMin;

        var normal = fromAbs / fromMaxAbs;

        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;

        var to = toAbs + toMin;

        return to;
    }

    private void FixedUpdate()
    { // ele disse "já que estamos lidando com física(mov do carro) é bom fazer isso num FixedUpdate
        moverCarro(movimento);
    }

    void moverCarro(Vector2 direcao)
    {
        rb.MovePosition((Vector2)transform.position + (direcao * moveSpeed * Time.deltaTime));
    }
}
