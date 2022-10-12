using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopping : MonoBehaviour
{
    public GameObject panel;
    
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.B))
            {  
                panel.SetActive(true);
            }
            if (Input.GetKeyUp(KeyCode.B))
            {
                panel.SetActive(false);
            }




    }
}
