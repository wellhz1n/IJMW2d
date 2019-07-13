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
    public static float Horizontal;
    //Mudar para PlayerAttack
    private BoxCollider2D playerAttack;

    //FIM++++++++++++
    // Start is called before the first frame update
    void Start()
    {
        //Mudar para PlayerAttack
        playerAttack = GameObject.Find("PlayerAttack").GetComponent<BoxCollider2D>();
        GameObject.Find("PlayerAttack").GetComponent<SpriteRenderer>().enabled = false;
        playerAttack.enabled = false;
        //FIM++++++++++++
        rg = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
        s = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");


        //Mudar para PlayerAttack
        if (Input.GetKeyDown(KeyCode.F))
        {

            a.SetBool("PA", true);


        }
        //FIM++++++++++++

        //Movimento Horizonatal

        if (Horizontal < 0)
        {
            s.flipX = true;
          
        }
        else
        {
            s.flipX = false;
            //Tudo isso vai ser excluido e trocado por animacao

          

        }
        a.SetFloat("Horizontal", Mathf.Abs(vel * Horizontal));
        rg.velocity = new Vector2(vel * Horizontal, rg.velocity.y);




        // Pulo



        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && Player.isGrounded)
        {

            if (Player.numeroDePulos < 3)
            {
                rg.AddForce(new Vector2(rg.velocity.x, jump * 5));
                a.SetBool("jump", true);
                Player.numeroDePulos++;
            }
            else
            {
                a.SetBool("jump", false);
            }

        }
        else
        {
            a.SetBool("jump", false);

        }
    }

    public void FimAttack()
    {
        a.SetBool("PA", false);
    }

    //Mudar para PlayerAttack

    //FIM++++++++++++
}
