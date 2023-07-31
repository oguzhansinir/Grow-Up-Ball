using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPuan : MonoBehaviour
{
    public Text EnYuksekPuan;

    
    int menuPuan;
    

    void Start()
    {
        menuPuan = Hafiza.PuanDegerOku();


        EnYuksekPuan.text = menuPuan.ToString();
    }


}
