using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour
{
    public TMP_Text coinText;
    public TMP_Text tinteText;
    public void coins(int coins)
    {
     
        coinText.text = coins.ToString() + " POINTS";
    }
    public void tinte(int tinte)
    {
        
        tinteText.text = tinte.ToString() + " TINTE";
    }
    public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Scena principala");
    }
    public void ExitButton()
    {

    }
}
