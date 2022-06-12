using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fundos : MonoBehaviour
{
    public SpriteRenderer sR;
    public Sprite[] spt;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, spt.Length);
        sR.sprite = spt[x];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
