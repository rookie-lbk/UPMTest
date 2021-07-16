using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CenturyGame.MyMotion.Editor
{
    public class MyMotionEditor
    {
        [MenuItem("MyMotion/CreateCube")]
        public static void CreateCube()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = "NewMotionCube";
            MyMotion myMotion = cube.AddComponent<MyMotion>();
            myMotion.transform.localPosition = Vector3.zero;
            myMotion.transform.localRotation = Quaternion.Euler(Vector3.zero);
            myMotion.transform.localScale = Vector3.one;
        }
    }
}