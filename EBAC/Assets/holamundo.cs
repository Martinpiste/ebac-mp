using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Hola desde awake");
    }

    void Start()
    {
        //print("Algo sucedio");
        //Debug.Log("Algo esta paso");
        //Debug.LogWarning("Algo salio mediamente mal");
        //Debug.LogError("Algo salio mal");
        Debug.LogWarning("Hola desde Start");


    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Hola esto es el Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Esto es le FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }




}
