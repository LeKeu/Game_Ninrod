using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] string cena;
    [SerializeField] KeyCode Key;
    
    void Update() {
        if(Input.GetKey(Key)){
            mudarCena();
        }  
    }
    public void mudarCena(){
        SceneManager.LoadScene(cena);
    }

}
