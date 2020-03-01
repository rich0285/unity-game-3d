using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int wantedEnemyCount = 10;


    IEnumerator enemyDrop()
    {
        while (enemyCount < wantedEnemyCount)
        {
            xPos = Random.Range(2, 57);
            zPos = Random.Range(-2, -57);
            Instantiate(theEnemy, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyDrop());
    }
}
