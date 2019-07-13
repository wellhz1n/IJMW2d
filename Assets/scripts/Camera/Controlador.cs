using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Transform posicaoDoPlayer;
    void Start()
    {
       
    }
    void Update()
    {
       transform.position = new Vector3(posicaoDoPlayer.position.x, posicaoDoPlayer.position.y, -10);
    }
}
