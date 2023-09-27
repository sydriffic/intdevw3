using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWin : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject textObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "nest")
        {
            textObj.SetActive(true);
        }
        else
        {
            textObj.SetActive(false);
        }
    }
}
