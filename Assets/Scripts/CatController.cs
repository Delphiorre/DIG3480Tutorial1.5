using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public AudioSource musicSource;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("escape")){
            Application.Quit();
        }

        /* The "State" parameter controls which animation cycle to play:
                0 means idle anim
                1 means walk anim
                2 means run anim
        */

        if(Input.GetKeyDown(KeyCode.W)){            //when W key held down,
            musicSource.clip = musicClipOne;        //change active audio clip to first audio clip
            musicSource.Play();                     //play active audio clip
            anim.SetInteger("State", 1);            //change to walking animation
        }

        if(Input.GetKeyUp(KeyCode.W)){              //when no longer holding W key
            musicSource.Stop();                     //stop active audio clip
            anim.SetInteger("State", 0);            //change to idle anim
        }

        if(Input.GetKeyDown(KeyCode.R)){
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            anim.SetInteger("State", 2); 
        }

        if(Input.GetKeyUp(KeyCode.R)){
            musicSource.Stop();
            anim.SetInteger("State", 0); 
        }
    }
}
