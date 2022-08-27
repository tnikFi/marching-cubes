using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class MeshGenerator {
    
    public static void GenerateMesh(Vector3[] vertices) {
        Vector3[] addedVertices = new Vector3[]{};

        for (int i = 0; i < vertices.Length; i++) {
            Vector3 vertex = vertices[i];
            
            if (!addedVertices.Contains(vertex)) {
                addedVertices = addedVertices.Append(vertex).ToArray();
            }
            
            // TODO
        }
    }
    
}


public class MeshData {
    public Vector3[] Vertices;
    public Triangle[] Triangles;
    
}


public struct Triangle {
    public Vector3 a;
    public Vector3 b;
    public Vector3 c;

    public Vector3 this[int i] {
        get {
            switch (i) {
                case 0:
                    return a;
                case 1:
                    return b;
                default:
                    return c;
            }
        }
    }

    public Triangle(Vector3 a, Vector3 b, Vector3 c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}