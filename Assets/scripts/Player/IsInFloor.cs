using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsInFloor : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao")
        {
            Player.isGrounded = true;
            Player.numeroDePulos = 0;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao"  && Player.numeroDePulos == 3)
        {
            Player.isGrounded = false;
        }
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
