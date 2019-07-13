using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Colisao : MonoBehaviour
{
    public UnityEvent evento;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
           public bool dentro;
private void OnTriggerEnter2D(Collider2D other) {
    if(other.name == player.name)
    {
        dentro = true;
         
    }

}
void OnTriggerExit2D(Collider2D other)
{
      if(other.name == player.name)
    {
        dentro = false;
       
    }
}
    // Update is called once per frame
    void Update()
    {
          if(dentro){

            evento.Invoke();
           }
    }
}
