using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
{
    public enum STATE
    {
        IDLE = 0,
        AGGROED = 1,
        ATTACKING = 2,
        DEFEATED = 3
    }

    public STATE state;

    void Update()
    {
        switch (state)
        {
            case STATE.IDLE:
                Debug.Log("Il nemico è fermo.");
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
