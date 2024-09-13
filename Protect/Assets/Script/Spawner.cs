using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public  float spawnTime;
    public int spawnCnt;

    int monsterCnt;

    public GameObject monster;

    private void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        if(spawnCnt <= monsterCnt)
        {
            yield return null;
        }


        Instantiate(monster, transform.position, Quaternion.identity);
        monsterCnt++;
        yield return new WaitForSeconds(spawnTime);
    }
}
