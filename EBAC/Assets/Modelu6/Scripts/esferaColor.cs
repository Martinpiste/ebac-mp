using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esferaColor : MonoBehaviour
{
    public GameObject esferacolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject esferacolor = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esferacolor.AddComponent<MeshFilter>();
        var meshFilter = esferacolor.GetComponent<MeshFilter>().mesh;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        esferacolor.AddComponent<BoxCollider>();
        esferacolor.AddComponent<MeshRenderer>();
        Color ec = new Color(Random.value, Random.value, Random.value);
        var meshRenderMaterial = esferacolor.GetComponent<MeshRenderer>().material;
        meshRenderMaterial.color = ec;
        esferacolor.transform.position = new Vector3(-3, 0.5f, 0);

    }
}
