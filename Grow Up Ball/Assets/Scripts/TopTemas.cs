using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopTemas : MonoBehaviour
{
    public bool temas = false;



    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "zemin" || collision.gameObject.tag == "ball")
        {
            temas = true;

        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (temas == true)
        {
            if(collision.gameObject.tag == "cizgi")
            {
                
                FindObjectOfType<OyunKontrol>().OyunBitti();
            }
        }
    }

}