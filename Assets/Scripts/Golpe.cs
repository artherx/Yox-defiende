using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Golpe : MonoBehaviour
{
    [SerializeField] private Animator Animacion;
    [SerializeField] private Camera cam;
    [SerializeField] private Collider2D puogo;
    private AudioSource audioSource;
    private int Vida = 100;
    private void Start()
    {
        cam = Camera.main;
        Animacion = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) 
        {
            Animacion.SetBool("Golpe", false);
            puogo.enabled = false;
            return; 
        }
        puogo.enabled = true;
        Vector2 posicionToque = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 posicionMundo = cam.ScreenToWorldPoint(posicionToque);
        audioSource.Play();
        Animacion.SetBool("Golpe", true);
        //Debug.Log(posicionMundo);
    }
    public void Toque(Boolean toq){
        
        if(toq == false) return;
        Vida-=15;
        if(Vida<1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }
}
