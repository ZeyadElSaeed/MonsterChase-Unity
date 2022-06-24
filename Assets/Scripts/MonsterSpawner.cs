using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;
    [SerializeField]
    private Transform leftSpawner , rightSpawner;

    private GameObject spawnedMonster;
    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnMonster()
    {
        while (true)
        {
        yield return new WaitForSeconds(Random.Range(1, 5));

        randomIndex = Random.Range(0, monsterReference.Length);
        randomSide = Random.Range(0, 2);

        spawnedMonster = Instantiate(monsterReference[randomIndex]);


        // left spawner
        if ( randomSide == 0)
        {
            spawnedMonster.transform.position = leftSpawner.transform.position;
            spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 8);
        }
        else
        // right spawner
        {
            spawnedMonster.transform.position = rightSpawner.transform.position;
            spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 8);
            spawnedMonster.transform.localScale = new Vector3(-1, 0.8f, 0);
        }
        }
        
    }
}
