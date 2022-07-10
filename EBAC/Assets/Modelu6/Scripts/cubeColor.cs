using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeColor : MonoBehaviour
{
    public GameObject cubocolor;

    private void Awake()
    {

        GameObject cubocolor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubocolor.AddComponent<MeshFilter>();
        var meshFilter = cubocolor.GetComponent<MeshFilter>().mesh;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        cubocolor.AddComponent<BoxCollider>();
        cubocolor.AddComponent<MeshRenderer>();
        Color cc = new Color(Random.value, Random.value, Random.value);
        var meshRenderMaterial = cubocolor.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = cc;
        cubocolor.transform.position = new Vector3(0, 0.5f, 0);



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
