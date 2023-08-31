using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Patogeno : MonoBehaviour
{
    public float speed = 4;
    private int Vida = 100;
    private Vector3 initialPosition;



    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate() {
        rb2D.velocity = Vector2.left*speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Restaurar la posición inicial
            transform.position = initialPosition;
            speed = 4;
            Vida += 15;
        }
    }
    public void PushBack(Vector2 pushDirection)
    {
        rb2D.velocity = pushDirection * 7000; // "pushSpeed" es la velocidad a la que se empujará hacia atrás

        Vida -= 25;
        if(speed>=1.5) speed = speed * 80 / 100;
        Debug.Log(Vida);
        if (Vida < 1)
        {
            Destroy(gameObject);
        }
        Debug.Log(pushDirection);
    }

}
