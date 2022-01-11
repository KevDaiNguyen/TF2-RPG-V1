using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoDied : MonoBehaviour
{
    public int AllEnemies;
    public int AllAllies;

    public WinScreen WinScreenObject;
    public LoseScreen LoseScreenObject;

    public bool screenSpawned;

    // Start is called before the first frame update
    void Start()
    {
        AllAllies = 0;
        AllEnemies = 0;
        screenSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (AllEnemies >= 4 && !screenSpawned)
        {
            WinScreenObject.OnWin();
            screenSpawned = true;
        }
        else if (AllAllies >= 4 && !screenSpawned)
        {
            screenSpawned = true;
        }
    }

    public void EnemyDied()
    {
        AllEnemies++;
    }

    public void AllyDied()
    {
        AllAllies++;
    }

}
