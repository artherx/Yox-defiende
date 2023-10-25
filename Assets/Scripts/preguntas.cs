using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntas : MonoBehaviour
{
    public static preguntas instance;
    public bool pre1;
    public int pre2;
    public bool pre3;
    public String email;

    private void Awake() {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(instance!=this)
            {
                Destroy(gameObject);
            }
        }
    }
}
