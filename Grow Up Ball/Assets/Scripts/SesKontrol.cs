using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{

    public AudioClip firlatma;
    public AudioClip buyume;
    public AudioClip oyunBitti;
    public AudioClip buttonSes;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonSes()
    {
        audioSource.clip = buttonSes;
        audioSource.Play();
    }

    public void FirlatmaSes()
    {
        audioSource.clip = firlatma;
        audioSource.Play();
    }

    public void BuyumeSes()
    {
        audioSource.clip = buyume;
        audioSource.Play();
    }

    public void OyunBittiSes()
    {
        audioSource.clip = oyunBitti;
        audioSource.Play();
    }


}
