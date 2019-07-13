using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.sceneCount >0)
        {
            anim.SetBool("Fade", false);
        }
        else
        {
            anim.SetBool("Fade", true);

        }
    }
}
