using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum STATE
{
    IDLE = 0,
    AGGROED = 1,
    ATTACKING = 2,
    DEFEATED = 3

}
public class EnemySwitchBehaviour : MonoBehaviour
{

    
    public STATE state = STATE.IDLE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.IDLE:
                Debug.Log("Il nemico è fermo");
                break;
                case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore");
                break;
                case STATE.ATTACKING:
                Debug.Log("Il nemico sta attacando il giocatore");
                break;
                case STATE.DEFEATED:
                Debug.Log("il nemico è scnofitto");
                break;

        }
        
    }
}
