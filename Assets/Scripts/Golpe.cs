using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Golpe : MonoBehaviour
{
    [SerializeField] private Animator Animacion;
    [SerializeField] private Camera cam;
    private void Start()
    {
        cam = Camera.main;
        Animacion = GetComponent<Animator>();
    }
    private void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) return;

        Vector2 posicionToque = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 posicionMundo = cam.ScreenToWorldPoint(posicionToque);
        Animacion.SetBool("Golpe", Input.touchCount!=0);
        Debug.Log(posicionMundo);
    }

}
