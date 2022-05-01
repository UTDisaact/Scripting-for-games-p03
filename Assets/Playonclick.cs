using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playonclick : MonoBehaviour

{

    public AudioSource someSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            someSound.Play();
        }
        

    }
}
