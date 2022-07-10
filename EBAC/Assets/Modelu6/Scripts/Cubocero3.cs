using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubocero3 : MonoBehaviour
{
    GameObject objToSpawn3;
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
        
    }

    private void OnEnable()
    {
        objToSpawn3 = new GameObject("Nuestro tercer Cubo");
        objToSpawn3.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn3.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn3.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn3.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn3.AddComponent<MeshRenderer>();
        var meshRenderMaterial = objToSpawn3.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = Color.red;
        objToSpawn3.transform.position = new Vector3(3, 3f, 0);
    }

    private void OnDisable()
    {
        objToSpawn3 = new GameObject("Nuestro tercer Cubo");
        objToSpawn3.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn3.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn3.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn3.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn3.AddComponent<MeshRenderer>();
        var meshRenderMaterial = objToSpawn3.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = Color.gray;
        objToSpawn3.transform.position = new Vector3(3, 3f, 0);

    }

}
