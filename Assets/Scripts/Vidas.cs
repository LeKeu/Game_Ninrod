using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int vida;
    public int numDeVidas;
    public Image[] vidas;
    public static int cena;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < vidas.Length; i++){
            if(i < numDeVidas){
                vidas[i].enabled = true;
            }else{
                vidas[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Inimigo"){
            numDeVidas--;
            Debug.Log("Num de vidas = " + numDeVidas);
            if(numDeVidas == 0){
                Debug.Log("GAME OVER");
                cena = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene("Perder");
            }else{
                Debug.Log("ENTROU VIDAS SCRIPT");
                Destroy(other.gameObject);
            }
            
        }
        if(other.gameObject.tag == "Monster"){
            cena = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("Perder");
        }
    }
}
