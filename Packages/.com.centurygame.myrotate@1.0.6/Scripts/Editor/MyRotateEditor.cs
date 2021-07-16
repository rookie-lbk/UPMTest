using UnityEditor;
using UnityEngine;

namespace CenturyGame.MyRotate.Editor
{
    public class MyRotateEditor
    {
        [MenuItem("MyRotate/CreateCube")]
        public static void CreateCube()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = "NewCube";
            MyRotate myRotate = cube.AddComponent<MyRotate>();
            myRotate.transform.localPosition = Vector3.zero;
            myRotate.transform.localRotation = Quaternion.Euler(Vector3.zero);
            myRotate.transform.localScale = Vector3.one;
        }
    }
}
