using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetAudioCount : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public GameObject myObject;
    public AudioSource newMusic;
    //public AudioClip music;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        



        if (audio1.isPlaying && audio2.isPlaying && audio3.isPlaying)
        {
            Destroy(myObject);
            newMusic.Play();

            //GameObject[] myObjects = GameObject.FindGameObjectsWithTag("remove");

            //foreach(GameObject singleObject in myObjects)
            //{
            //    Destroy(singleObject);
            //}




          
                




            

        }
    }
}
