using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum DAMAGE_TYPE
{
    SLASHING  = 0,
    PIERCING = 1,
    BLUDGEONING = 2,
    MAGICAL = 3,
    FORCE = 4,

}

public class DamageTypeExample : MonoBehaviour
{

    public int baseDamage = 100;
    public DAMAGE_TYPE attackType = DAMAGE_TYPE.MAGICAL;
    public DAMAGE_TYPE resistance = DAMAGE_TYPE.MAGICAL;
    public DAMAGE_TYPE weakness = DAMAGE_TYPE.FORCE;






    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log("Non era molto efficace...");
            Debug.Log(baseDamage);
        }
        else if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("È superefficace!");
            Debug.Log(baseDamage);
        }
        else 
        {
            Debug.Log(baseDamage);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
