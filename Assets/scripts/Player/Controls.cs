using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float vel = 10f;
    public float jump = 10f;
    Rigidbody2D rg;
    Animator a;
    SpriteRenderer s;
    float Horizontal;
    //Mudar para PlayerAttack
    private GameObject playerAttack;
    BoxCollider2D pa;
    SpriteRenderer pr;
    //FIM++++++++++++
    // Start is called before the first frame update
    void Start()
    {
        //Mudar para PlayerAttack
        playerAttack = GameObject.Find("PlayerAttack");
        pa = playerAttack.GetComponent<BoxCollider2D>();
        pr = playerAttack.GetComponent<SpriteRenderer>();
        pa.enabled = false;
        pr.enabled = false;
        //FIM++++++++++++
        rg = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
        s = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Mudar para PlayerAttack
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (pa.enabled)
            {
                DesativaPA();
            }
            else
            {
                pa.enabled = true;
                pr.enabled = true;

                Invoke("DesativaPA", 0.5f);
            }
   
            

        }
        //FIM++++++++++++

        //Movimento Horizonatal

        Horizontal = Input.GetAxis("Horizontal");
        if (Horizontal < 0)
        {
            s.flipX = true;
        }
        else
        {
            s.flipX = false;
        }
        a.SetFloat("Horizontal", Mathf.Abs(vel*Horizontal));
        rg.velocity = new Vector2( vel*Horizontal, rg.velocity.y);




        // Pulo


     
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && Player.isGrounded)
        {   
            
            if(Player.numeroDePulos<3){
                rg.AddForce(new Vector2(rg.velocity.x, jump*5));
                a.SetBool("jump",true);
                Player.numeroDePulos++;
            } 

        }
        else
        {
            a.SetBool("jump",false);

        }
    }



    //Mudar para PlayerAttack
    private void DesativaPA()
    {
        pa.enabled = false;
        pr.enabled = false;

    }
    //FIM++++++++++++
}
