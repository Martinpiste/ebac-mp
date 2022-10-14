using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboZero : MonoBehaviour
{
    public GameObject x ;

    private void Awake()
    {
        
        GameObject x = GameObject.CreatePrimitive(PrimitiveType.Cube);
        x.AddComponent<MeshFilter>();
        var meshFilter = x.GetComponent<MeshFilter>().mesh;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        x.AddComponent<BoxCollider>();
        x.AddComponent<MeshRenderer>();
        var meshRenderMaterial = x.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = Color.yellow;
        x.transform.position = new Vector3(2, 5, 2);



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
