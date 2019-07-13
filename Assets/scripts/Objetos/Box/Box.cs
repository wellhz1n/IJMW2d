using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField]
    private int life = 3;
    public Sprite[] img = new Sprite[4];
    SpriteRenderer sr;
    public Sprite fim;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (life)
        {
            case 3:
                sr.sprite = img[0];
                break;
            case 2:
                sr.sprite = img[1];
                break;
            case 1:
                sr.sprite = img[2];
                break;
            case 0:

                Animator anim = this.GetComponent<Animator>();
                anim.enabled = true;
                Destroy(this.GetComponent<BoxCollider2D>());

                Destroy(anim, 1);
                Destroy(this.GetComponent<Box>(), 1);

                break;
            default:
                break;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PlayerAttack")
        {
            life--;
        }
    }


}
