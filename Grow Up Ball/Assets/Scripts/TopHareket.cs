using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    float hiz = 0.008f;
    bool hareketBasladi = true;

    public static Touch parmak;

    Rigidbody2D rb;
    //float topHiz = 5f;

    //public GameObject solDuvar, sagDuvar;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            parmak = Input.GetTouch(0);
            
            if (parmak.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + parmak.deltaPosition.x * hiz, transform.position.y);

                Vector2 topSinir = transform.position;
                topSinir.x = Mathf.Clamp(topSinir.x, -EkranHesaplayicisi.Instance.Genislik, EkranHesaplayicisi.Instance.Genislik);
                transform.position = topSinir;



                //rb.velocity = new Vector2(parmak.position.x * hiz, 0);

                //if (parmak.deltaPosition.x > 0)
                //{
                //    rb.velocity = new Vector2(parmak.deltaPosition.x * hiz, 0);
                //}
                //else if (parmak.deltaPosition.x < 0)
                //{
                //    rb.velocity = new Vector2(parmak.deltaPosition.x * hiz, 0);
                //}
                //else if (parmak.deltaPosition.x == 0)
                //{
                //    rb.velocity = Vector2.zero;
                //}
                
                


                hareketBasladi = false;
            }
            else if (parmak.phase == TouchPhase.Ended && !hareketBasladi)
            {
                Destroy(transform.GetComponent<TopHareket>());
                FindObjectOfType<SesKontrol>().FirlatmaSes();
                transform.GetComponent<Rigidbody2D>().gravityScale = 1;
                TopOlustur.prefabOlustur = true;
            }
        }

    }

}