using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Golpe : MonoBehaviour
{
    [SerializeField] private Animator Animacion;
    [SerializeField] private Camera cam;
    [SerializeField] private Collider2D puñogo;
    //private int Vida = 100;
    private void Start()
    {
        cam = Camera.main;
        Animacion = GetComponent<Animator>();
    }
    private void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) 
        {
            Animacion.SetBool("Golpe", false);
            puñogo.enabled = false;
            return; 
        }
        puñogo.enabled = true;
        Vector2 posicionToque = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 posicionMundo = cam.ScreenToWorldPoint(posicionToque);
        Animacion.SetBool("Golpe", true);
        Debug.Log(posicionMundo);
    }
}
