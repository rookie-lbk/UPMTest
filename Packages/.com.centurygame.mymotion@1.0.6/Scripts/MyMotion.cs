using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CenturyGame.MyMotion
{
    public class MyMotion : MonoBehaviour
    {
        private Vector3 rotatePos;
        private readonly float Speed = 0.1f;

        // Start is called before the first frame update
        void Start()
        {
            MyRotate.MyRotate rotate = gameObject.AddComponent<MyRotate.MyRotate>();
            rotate.MyRotateSpeed = 120.0f;
            rotatePos = transform.position + new Vector3(0, 0, 10);
        }

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(rotatePos, Vector3.up, Speed);
        }
    }
}