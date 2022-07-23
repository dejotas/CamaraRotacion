using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camararotacion : MonoBehaviour
{
    public float LongRay = 6.0f;

    public float Altura = 1.0f;
    public float Distancia = 1.0f;

    public Transform transPlayer;
    public Transform transCamara;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 player = transPlayer.position;
        Vector3 playerUp = transPlayer.up;
        Vector3 playerForward = transPlayer.forward;

        Vector3 resultado = player + playerUp * Altura - playerForward * Distancia;

        transCamara.position = resultado;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * LongRay, Color.blue);
        
    }
}
