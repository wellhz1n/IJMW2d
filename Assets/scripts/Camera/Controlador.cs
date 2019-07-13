using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Transform posicaoDoPlayer;
    void Start()
    {
       
    }
    void FixedUpdate()
    {
       transform.position = new Vector3((posicaoDoPlayer.position.x)-Time.deltaTime,(posicaoDoPlayer.position.y)*Time.deltaTime + 1, -10);
    }
}
