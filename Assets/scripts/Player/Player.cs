using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private  float Life = Mathf.Abs(100f);
    public Vector2 posicaoSpawn;
    // Start is called before the first frame update
    void Start()
    {   
    posicaoSpawn = transform.position;
    }
    public void TiraVida(){

    Life -= 10*Time.deltaTime;

    }

    public void Morrer() {
        transform.position = posicaoSpawn;
        Life =  Mathf.Abs(100f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Life <= 0) {
            
            Morrer();
            
        }
    }
}
