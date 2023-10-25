using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preg3 : MonoBehaviour
{
    
    public void Juegar()
    {
        preguntas.instance.pre3 = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Atra()
    {
        preguntas.instance.pre3 = false;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Salir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
