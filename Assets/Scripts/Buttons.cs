using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    int teste = Vidas.cena;

    //public Monstro MonstroScript;
    [SerializeField] string cena;
    [SerializeField] KeyCode Key;
    [SerializeField] KeyCode Key2;

    void Update()
    {
        //Debug.Log("buttons " + teste);
        if (Input.GetKey(Key))
        {
            mudarCena();
        }
        if (Input.GetKey(Key2))
        {
            gameOverMudarCena();
        }
    }
    public void mudarCena()
    {
        SceneManager.LoadScene(cena);
    }

    public void gameOverMudarCena()
    {
        SceneManager.LoadScene(teste);
    }

    public void sair()
    {
        Application.Quit();
    }
}
