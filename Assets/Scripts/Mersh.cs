using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Mersh : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MeshFilter mf = GetComponent<MeshFilter>();
        MeshRenderer mr = GetComponent<MeshRenderer>();

        

        Vector3 p1 = new Vector3(1, 1, 1);
        Vector3 p2 = new Vector3(1, 2, 1);
        Vector3 p3 = new Vector3(2, 2, 1);
        Vector3 p4 = new Vector3(2, 1, 1);

        Vector3[] vertices = new Vector3[4];
        vertices[0] = p1;
        vertices[1] = p2;
        vertices[2] = p3;
        vertices[3] = p4;


        int[] triangles = new int[6];
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 3;
        triangles[3] = 1;
        triangles[4] = 2;
        triangles[5] = 3;

        Mesh mes = new Mesh();

        mf.mesh = mes;

        mes.vertices = vertices;

        mes.triangles = triangles;
        
        
        mes.RecalculateBounds();
        mes.RecalculateNormals();

        

    }
	
	
}
