using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleColor : MonoBehaviour
{
    public GameObject capsulecolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject capsulecolor = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsulecolor.AddComponent<MeshFilter>();
        var meshFilter = capsulecolor.GetComponent<MeshFilter>().mesh;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        capsulecolor.AddComponent<BoxCollider>();
        capsulecolor.AddComponent<MeshRenderer>();
        Color cc = new Color(Random.value, Random.value, Random.value);
        var meshRenderMaterial = capsulecolor.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = cc;
        capsulecolor.transform.position = new Vector3(3, 0.5f, 0);
    }
}
