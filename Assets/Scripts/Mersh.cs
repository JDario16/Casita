using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;


[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Mersh : MonoBehaviour {

    // Use this for initialization
    void Start() {
        MeshFilter mf = GetComponent<MeshFilter>();
        MeshRenderer mr = GetComponent<MeshRenderer>();
        string[] content = System.IO.File.ReadAllLines(@"Assets\\Scripts\\Casa.txt");
        string[] auxiliar;

        
        



        Vector3 p1 = new Vector3(1, 1, 1);
        Vector3 p2 = new Vector3(1, 2, 1);
        Vector3 p3 = new Vector3(2, 2, 1);
        Vector3 p4 = new Vector3(2, 1, 1);

        List<Vector3> vertice = new List<Vector3>();
        int i=0;
        foreach (string line in content)
        {
            // Use a tab to indent each line of the file.
            auxiliar = content[i].Split(' ');
            vertice.Add(new Vector3((float) Convert.ToDouble(auxiliar[0]), (float)Convert.ToDouble(auxiliar[1]), (float)Convert.ToDouble(auxiliar[2])));
            i = i + 1;
        }

        Vector3[] vertices = new Vector3[vertice.Count];
        for (int j = 0; j < vertice.Count; j++) {
            vertices[j] = vertice[j];
        }
        /*vertices[0] = p1;
        vertices[1] = p2;
        vertices[2] = p3;
        vertices[3] = p4;*/


        int[] triangles = new int[vertices.Length];

        for (int j = 0; j < vertices.Length; j++) {
            triangles[j] = j;
        }
        /*triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 1;
        triangles[4] = 2;
        triangles[5] = 3;*/

        Mesh mes = new Mesh();

        mf.mesh = mes;

        mes.vertices = vertices;

        mes.triangles = triangles;
        
        
        mes.RecalculateBounds();
        mes.RecalculateNormals();

        

    }
	
	
}
