using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubocero2 : MonoBehaviour
{

    GameObject objToSpawn2;
    Vector3[] vertices = {
        new Vector3 (0, 0, 0), //vertice0
        new Vector3 (1, 0, 0), //vertice1
        new Vector3 (1, 1, 0), //vertice2
        new Vector3 (0, 1, 0), //vertice3
        new Vector3 (0, 1, 1), //vertice4
        new Vector3 (1, 1, 1), //vertice5
        new Vector3 (1, 0, 1), //vertice6
        new Vector3 (0, 0, 1), //vertice7
    };

    int[] triangulos = {
        0, 2, 1, //cara1
        0, 3, 2,
        2, 3, 4, //cara2
        2, 4, 5,
        1, 2, 5, //cara3
        1, 5, 6,
        0, 7, 4, //cara4
        0, 4, 3,
        5, 4, 7, //cara5
        5, 7, 6,
        0, 6, 7, //cara1
        0, 1, 6,
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objToSpawn2 = new GameObject("Nuestro segundo Cubo");
        objToSpawn2.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn2.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn2.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn2.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn2.AddComponent<MeshRenderer>();
        var meshRenderMaterial = objToSpawn2.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = Color.green;
        objToSpawn2.transform.position = new Vector3(0, 3f, 0);

    }
}
