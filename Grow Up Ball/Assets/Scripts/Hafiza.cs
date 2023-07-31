using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Hafiza
{
    public static string skor = "skor";

    public static void PuanDegerAta(int skor)
    {
        PlayerPrefs.SetInt(Hafiza.skor, skor);
    }

    public static int PuanDegerOku()
    {
        return PlayerPrefs.GetInt(Hafiza.skor);
    }
}
