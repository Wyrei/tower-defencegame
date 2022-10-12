using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class oncollision : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI healthover;
    private void Update()
    {
        healthover.text = health.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
