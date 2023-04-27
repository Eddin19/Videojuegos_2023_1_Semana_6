using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRespawn : MonoBehaviour
{
    private int currentTime = 0;
    public const float RESPAWN_TIME = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        InvokeRepeating("RespawnCoin", 0.0f, 2.0f);
    }

    // Update is called once per frame
    public void RespawnCoin(){
        if (!this.gameObject.activeSelf && currentTime >= RESPAWN_TIME){
            this.gameObject.SetActive(true);
            currentTime = 0;
            return;
        }
        currentTime +=2;
    }
}
