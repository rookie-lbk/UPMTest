
using UnityEngine;

namespace CenturyGame.MyRotate
{
    public class MyRotate : MonoBehaviour
    {
        public float MyRotateSpeed = 10.0f;

        void Start()
        {
            Debug.Log("MyRotate Start");
        }

        void Update()
        {
            // this.transform.RotateAround(Vector3.zero, Vector3.up, MyRotateSpeed);
            var rot = Quaternion.AngleAxis(MyRotateSpeed * Time.deltaTime, Vector3.up);
            transform.localRotation = rot * transform.localRotation;
        }
    }
}
