using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    private Transform upgrade;
    
    
    public void upgradedamage()
    {
        
        bulletshoot daamage = upgrade.GetComponent<bulletshoot>();
        daamage.damage += 10;
        
    }
    public void upgraderange()
    {
        TowerShoot Range = upgrade.GetComponent<TowerShoot>();
       
        Range.range += 10;
    }
}
