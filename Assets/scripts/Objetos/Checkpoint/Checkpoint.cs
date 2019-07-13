using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector2 posi;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        posi.x = this.GetComponent<Transform>().position.x;
        posi.y = this.GetComponent<Transform>().position.y;
        anim.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.posicaoSpawn = posi;
            anim.enabled = true;
            Destroy(anim, 1);
            Destroy(this.GetComponent<Checkpoint>(), 1);
            Destroy(this.GetComponent<BoxCollider2D>(), 1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
