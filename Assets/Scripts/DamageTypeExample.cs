using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateSystem;

public class DamageTypeExample : MonoBehaviour
{
    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage = 50;
    // Start is called before the first frame update
    void Start()
    {
        int realDamage = 0;
        if (attackType == resistance)
        {
            realDamage = baseDamage / 2;
            Debug.Log("Il nemico è resistente a " + resistance + " il tuo attacco base è di " + baseDamage);
        }
        else if (attackType == weakness) 
        {
            realDamage = baseDamage * 2;
            Debug.Log("Il nemico è debole a " + weakness + " il tuo attacco base è di " + baseDamage);
        }

        Debug.Log("il danno inflitto è di  " + realDamage);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
