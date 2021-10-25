using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    public float liveEnemy = 7.0f;
    bool isForward = true;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        MoveTowards();
        /*
        if (isForward)
        {
            MoveEnemy(Vector3.forward);
        }
        else
        {
            MoveEnemy(Vector3.back);
        }

        if (transform.position.x < 0f && !isForward)
        {
            isForward = true;
        }

        if (transform.position.x > 20f && isForward)
        {
            isForward = false;
        }

        liveEnemy -= Time.deltaTime;

        if (liveEnemy <= 0)
        {
            Destroy(gameObject);
        }
        */
    }
    private void MoveEnemy(Vector3 direction)
    {
        transform.Translate(speedEnemy * Time.deltaTime * direction);
    }

    private void MoveTowards()
    {
        Vector3 direction   = (player.transform.position - transform.position).normalized;
        transform.position += speedEnemy * direction * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }

}
