using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public Transform enemyprefab;
    public Transform spawnpoint;

    public float timebetweenwaves = 5f;
    public float countdown = 1f;

    public int wavenumber = 2;

    void Update()
    {
       
        if (countdown <= 0f)
        {
            StartCoroutine(spawnwaves());
            countdown = timebetweenwaves;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator spawnwaves()
    {
        wavenumber++;
        for (int i = 0; i < wavenumber; i++)
        {
            spawnenemy();
            yield return new WaitForSeconds(0.25f);
        }
        
    }
    void spawnenemy()
    {
        Instantiate(enemyprefab, spawnpoint.position, spawnpoint.rotation);
    }
}
