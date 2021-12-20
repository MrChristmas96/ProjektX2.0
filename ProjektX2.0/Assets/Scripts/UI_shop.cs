using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_shop : MonoBehaviour
{

    private void Start()
    {
        HideP1();
        HideP2();
    }

    public void ShowP1()
    {
        gameObject.SetActive(true);

    }
    public void HideP1()
    {
        gameObject.SetActive(false);
    }

    public void ShowP2()
    {
        gameObject.SetActive(true);

    }
    public void HideP2()
    {
        gameObject.SetActive(false);
    }


}
