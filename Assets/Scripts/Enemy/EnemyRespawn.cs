using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    //public Transform puntos;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public int maxEnemies;
    private int currentEnemies = 0;
    public float respawnTime = 5.0f;
    private float respawnTimer = 0.0f;

    /*
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            respawnTimer = respawnTime;
        }
    }
    */
    private void Update()
    {
        bool PlayerMuerto = playerPrefab.GetComponent<PlayerController>().Muerte;
        respawnTimer -= Time.deltaTime;
        if (respawnTimer <= 0.0f && !PlayerMuerto)
        {
            RespawnEnemy();
            respawnTimer = respawnTime;
        }
    }

    private void RespawnEnemy()
    {
        if (currentEnemies < maxEnemies)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            currentEnemies++;
        }
    }
}
