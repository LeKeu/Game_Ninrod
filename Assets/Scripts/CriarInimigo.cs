using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CriarInimigo : MonoBehaviour
{
    [SerializeField] GameObject inimigo;
    [SerializeField] float tempo_respawn;
    [SerializeField] Transform monstro; //monoto
    public Image img1;
    public Image img2;
    public Image img3;
    // pegar as imagens aqui e fazer o código p apagar elas aqui tbm, n no Inimigo.cs
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(inimigo_wave());
        Instantiate(inimigo);
        inimigo.transform.position = new Vector2(20, -80);
    }

    private void criar_inimigo(){
        Instantiate(inimigo);
        inimigo.transform.position = new Vector2(Random.Range(-10, 10), monstro.position.y);
    }

    IEnumerator inimigo_wave(){
        while(true){
            yield return new WaitForSeconds(tempo_respawn); //aparentemente, isso faz esperar x segundos antes de prosseguir
            criar_inimigo();
        }
    }
}
