using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preg2 : MonoBehaviour
{
    
    limiteN limit ;
    public void Juegar()
    {
        preguntas.instance.pre2 = limit.GetEntero();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Atra()
    {
        preguntas.instance.pre2 = 0;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Salir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
