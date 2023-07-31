using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject durdurPanel;
    public GameObject oyunBittiPanel;

    //public Canvas canvas;

    //public void Start()
    //{
    //    canvas = GetComponent<Canvas>();
    //    canvas.renderMode = RenderMode.ScreenSpaceCamera;
    //    canvas.worldCamera = Camera.main;
    //}
    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun");
        //oyunBittiPanel.SetActive(false);
        //durdurPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void DevamEt()
    {
        durdurPanel.SetActive(false);
        oyunBittiPanel.SetActive(false);
        //canvas.sortingLayerID = 0;
        //canvas.sortingLayerName = "Default";
        Time.timeScale = 1;
    }


    public void Durdur()
    {
        durdurPanel.SetActive(true);
        oyunBittiPanel.SetActive(false);
        //canvas.sortingLayerID = 2;
        //canvas.sortingLayerName = "Button";
        Time.timeScale = 0;
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("Oyun");
        oyunBittiPanel.SetActive(false);
        durdurPanel.SetActive(false);
        // canvas.sortingLayerID = 0;
        //canvas.sortingLayerName = "Default";
        Time.timeScale = 1;
    }

    public void Anemenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OyunBitti()
    {
        FindObjectOfType<SesKontrol>().OyunBittiSes();
        FindObjectOfType<Puan>().OyunBitti();
        //FindObjectOfType<Puan>().PuanSifirla();
        // canvas.sortingLayerID = 2;
        //canvas.sortingLayerName = "Button";
        FindObjectOfType<TopTemas>().temas = false;
        oyunBittiPanel.SetActive(true);
        durdurPanel.SetActive(false);
        
    }

}
