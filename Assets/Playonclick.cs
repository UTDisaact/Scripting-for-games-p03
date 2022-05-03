using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playonclick : MonoBehaviour

{
    public bool lockCursor = true;

    public AudioSource someSound;
    // Start is called before the first frame update
    void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
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
