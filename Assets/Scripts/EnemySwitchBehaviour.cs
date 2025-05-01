using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateSystem;


public class EnemySwitchBehaviour : MonoBehaviour
{
    public STATE STATE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (STATE)
        {
            case STATE.IDLE:
                Debug.Log("Il Nemico è fermo.");
                break;
            case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore.");
                break;
            case STATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;
            case STATE.DEFEATED:
                Debug.Log("Il nemico è sconfitto.");
                break;


        }
    }
}
