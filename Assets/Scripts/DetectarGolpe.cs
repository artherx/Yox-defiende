using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarGolpe : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Patogeno"))
        {
            Vector2 push = (collision.transform.position-transform.position).normalized;

            Patogeno patogeno = collision.gameObject.GetComponent<Patogeno>();
            patogeno.PushBack(push);
            //Debug.Log("ha golpeado");
        }
    }

}
