using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puan : MonoBehaviour
{
    public Text PuanText;
    public Text EnYuksekPuanText;
    public Text OyunBittiPuanText;

    public int puan = 0;
    public int enYuksekPuan;

    bool puanKazan;

    private void Start()
    {
        puanKazan = true;

        PuanText.text = puan.ToString();
    }

    public void birPuanKazan()
    {
        if (puanKazan)
        {
            puan++;
            PuanText.text = puan.ToString();
        }
        
    }

    public void ikiPuanKazan()
    {
        if (puanKazan)
        {
            puan += 2;
            PuanText.text = puan.ToString();
        }
        
    }

    public void ucPuanKazan()
    {
        if (puanKazan)
        {
            puan += 3;
            PuanText.text = puan.ToString();
        }
        
    }

    public void dortPuanKazan()
    {
        if (puanKazan)
        {
            puan += 4;
            PuanText.text = puan.ToString();
        }
        
    }

    public void besPuanKazan()
    {
        if (puanKazan)
        {
            puan += 5;
            PuanText.text = puan.ToString();
        }
        
    }

    public void altiPuanKazan()
    {
        if (puanKazan)
        {
            puan += 6;
            PuanText.text = puan.ToString();
        }
        
    }

    public void yediPuanKazan()
    {
        if (puanKazan)
        {
            puan += 7;
            PuanText.text = puan.ToString();
        }
        
    }

    public void sekizPuanKazan()
    {
        if (puanKazan)
        {
            puan += 8;
            PuanText.text = puan.ToString();
        }
        
    }

    public void PuanSifirla()
    {
        puan = 0;
    }


    public void OyunBitti()
    {       
        enYuksekPuan = Hafiza.PuanDegerOku();
        OyunBittiPuanText.text = puan.ToString();

        if (puan >= enYuksekPuan)
        {
            enYuksekPuan = puan;
            Hafiza.PuanDegerAta(puan);
        }
        

        puanKazan = false;
        EnYuksekPuanText.text = enYuksekPuan.ToString();
    }
}
