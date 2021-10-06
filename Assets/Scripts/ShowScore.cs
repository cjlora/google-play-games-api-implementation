using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI score_field;

    public void DisplayScore()
    {
        string x = score_field.text;
        Debug.Log(int.Parse(x));
    }
}
