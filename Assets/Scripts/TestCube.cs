using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : MonoBehaviour {
    [Range(0, 256)] public int corners;

    public bool[] values;

    public void Draw() {
        CubeMeshCreator.RenderCube(values);
    }
}