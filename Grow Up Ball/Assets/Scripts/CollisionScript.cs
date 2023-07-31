using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    public int value;
    public GameObject nextBall;
    public Rigidbody2D rb;
    public int ID;


    public GameObject pinponPrefab, bilardoPrefab, tenisPrefab, golfPrefab, beyzbolPrefab, bowlingPrefab, voleybolPrefab,
        futbolPrefab, basketbolPrefab;



    public static int once = 1;


    private void Awake()
    {
        ID = GetInstanceID();
        rb = GetComponent<Rigidbody2D>();

        if (gameObject == basketbolPrefab)
        {
            nextBall.SetActive(false);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("ball"))
        {
            if (collision.gameObject.TryGetComponent(out CollisionScript ball))
            {               
                if (ball.value == value && once == 1)
                {
                    if (ID < ball.ID) return;

                    //if (gameObject.name == "Basketbol")
                    //{
                    //    nextBall.SetActive(false);

                    //}

                    //if (gameObject == basketbolPrefab)
                    //{
                    //    if (collision.gameObject.tag == "basketbol")
                    //    {
                    //        nextBall.SetActive(false);
                    //    }
                    //}

                    



                    Destroy(this.gameObject);
                    Destroy(collision.gameObject);

                    if (nextBall)
                    {
                        GameObject temp = Instantiate(nextBall, transform.position, Quaternion.identity);
                        temp.transform.GetComponent<Rigidbody2D>().gravityScale = 1;
                        FindObjectOfType<SesKontrol>().BuyumeSes();
                        
                        if (nextBall == bilardoPrefab)
                        {
                            FindObjectOfType<Puan>().birPuanKazan();
                        }
                        else if(nextBall== tenisPrefab)
                        {
                            FindObjectOfType<Puan>().ikiPuanKazan();
                        }
                        else if (nextBall == golfPrefab)
                        {
                            FindObjectOfType<Puan>().ucPuanKazan();
                        }
                        else if (nextBall == beyzbolPrefab)
                        {
                            FindObjectOfType<Puan>().dortPuanKazan();
                        }
                        else if (nextBall == bowlingPrefab)
                        {
                            FindObjectOfType<Puan>().besPuanKazan();
                        }
                        else if (nextBall == voleybolPrefab)
                        {
                            FindObjectOfType<Puan>().altiPuanKazan();
                        }
                        else if (nextBall == futbolPrefab)
                        {
                            FindObjectOfType<Puan>().yediPuanKazan();
                        }
                        else if (nextBall == basketbolPrefab)
                        {
                            FindObjectOfType<Puan>().sekizPuanKazan();
                        }

                        Destroy(temp.transform.GetComponent<TopHareket>());

                    }
                    once = 0;
                }
            }
        }
 
    }

    
}
