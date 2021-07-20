using System.Collections;
using System.Collections.Generic;
using CenturyGame.MyMotion;
using CenturyGame.MyRotate;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.AddComponent<MyMotion>();
        this.gameObject.AddComponent<MyRotate>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
