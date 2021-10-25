using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{

    //enum Difficulties { Easy, Normal, Hard };
    enum Difficulties { Easy = 1, Normal, Hard };

    [SerializeField] private GameObject[] enemyPrefabs;
    //public float startDelay = 2;
    //public float spawnInterval = 1.5f;
    //public int difficulty = 1;
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;
    //[SerializeField] private int   difficulty = 1;
    [SerializeField] private Difficulties difficulty;

    void Start()
    {
        Debug.Log(difficulty);
        Debug.Log(((int)difficulty));
        /*
        switch (difficulty)
        {
            case 1:
                Debug.Log("FACIL");
                InvokeRepeating("SpawnEnemy", (startDelay + 3f), (spawnInterval + 3f));
            break;
            case 2:
                Debug.Log("NORMAL");
                InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
            break;
            case 3:
                Debug.Log("DIFICIL");
                InvokeRepeating("SpawnEnemy", (startDelay - 1f), (spawnInterval - 1f));
            break;
            default:
                Debug.Log("<color=#FF0000>ERROR AL ELEGIR NIVEL</color>");
                break;
        }*/
       switch (difficulty)
       {
           case Difficulties.Easy:
               Debug.Log("FACIL");
               InvokeRepeating("SpawnEnemy", (startDelay + 3f), (spawnInterval + 3f));
           break;
           case Difficulties.Normal:
               Debug.Log("NORMAL");
               InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
           break;
           case Difficulties.Hard:
               Debug.Log("DIFICIL");
               InvokeRepeating("SpawnEnemy", (startDelay - 1f), (spawnInterval - 1f));
           break;
           default:
               Debug.Log("<color=#FF0000>ERROR AL ELEGIR NIVEL</color>");
               break;
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], transform.position, enemyPrefabs[enemyIndex].transform.rotation);
    }

}
