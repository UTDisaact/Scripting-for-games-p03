﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    float x;
    void Update()
    {
        x += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

}