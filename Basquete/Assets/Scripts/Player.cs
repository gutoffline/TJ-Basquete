using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bola;
    public GameObject playerCamera;
    public float distanciaBola = 2f;
    //método Start é executado apenas na criação do objeto
    void Start()
    {
        bola.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        bola.transform.position = playerCamera.transform.position + playerCamera.transform.forward * distanciaBola;
    }
}
