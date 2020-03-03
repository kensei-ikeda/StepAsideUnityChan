using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{//Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Use this for initialization
    void Start()
    { //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
      
    }
    // Update is called once per frame
    void Update()
        
    {
       
        if (unitychan.transform.position.z -5 > this.transform.position.z ) 
        {
            Destroy(this.gameObject);
        }

    }
}

