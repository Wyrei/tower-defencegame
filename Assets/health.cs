using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{
    public float Health = 10f;
    public TextMeshProUGUI healthdisplay;
    void Update()
    {
        healthdisplay.text = Health.ToString();
    }
}
