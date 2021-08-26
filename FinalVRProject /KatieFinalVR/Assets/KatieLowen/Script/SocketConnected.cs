using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SocketConnected : MonoBehaviour

{
    public GameObject hatSocket;
    public GameObject witchHat;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider witchHat)
    {
        if (witchHat.name == "WitchHat")
        {


            GameObject[] myObjects = GameObject.FindGameObjectsWithTag("remove");

            foreach (GameObject singleObject in myObjects)
            {
                Destroy(singleObject);
            }
            //SceneManager.LoadScene("MeilinVR");
        }
    }
}
