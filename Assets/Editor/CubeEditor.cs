using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestCube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI() {
        TestCube cube = (TestCube) target;
        
        if (DrawDefaultInspector()) {
            CubeMeshCreator.RenderCube(cube.values);
        }

        if (GUILayout.Button("Draw")) {
            CubeMeshCreator.RenderCube(cube.values);
        }
    }
}
