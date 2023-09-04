using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Patogeno : MonoBehaviour
{
    [SerializeField] private VIDABac barraVida;

    public float speed = 4;
    private float Vida = 150;
    private Vector3 initialPosition;



    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
        barraVida.IniciarBarras(Vida);

    }

    // Update is called once per frame
    private void FixedUpdate() {
        rb2D.velocity = Vector2.left*speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Restaurar la posici�n inicial
            Golpe personaje = collision.transform.GetComponent<Golpe>();            transform.position = initialPosition;
            personaje.Toque(true);
            if(speed<=10) speed = speed + (speed*25/100);
            if(Vida <=150){
               Vida += 15;
               if(Vida >150) Vida=150;
               barraVida.editVB(Vida);
            }
        }
    }
    public void PushBack(Vector2 pushDirection)
    {
        rb2D.velocity = pushDirection * 7000; // "pushSpeed" es la velocidad a la que se empujar� hacia atr�s

        Vida -= 25;
        if(Vida < 0) Vida=0;
        barraVida.editVB(Vida);
        if(speed>=1.5) speed = speed * 80 / 100;
        //Debug.Log(Vida);
        if (Vida < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        //Debug.Log(pushDirection);
    }

}
