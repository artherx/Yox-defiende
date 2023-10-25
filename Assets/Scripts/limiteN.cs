using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class limiteN : MonoBehaviour
{
    public TMP_InputField iNput;
    
    private int entero= 0;
    private void Update() {
        mirarT();
    }
    public void mirarT()
    {
        
        if(iNput.text=="") return ;
        else
        {
            entero= Convert.ToInt16(iNput.text);
            if(entero<=0) entero = 1;
            if(entero>10) entero = 10;
            iNput.text = entero.ToString();
            Debug.Log(iNput.text);
        }
    }
    public int GetEntero()
    {
        return entero;
    }
}
