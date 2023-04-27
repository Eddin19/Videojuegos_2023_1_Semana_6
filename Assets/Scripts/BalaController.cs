using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public GameObject gameManager;
    public float velocityX = 0.1f;
    public float velocityY = 0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, velocityY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        int disparosNecesarios = 2;
        int disparos = 0;
        if (other.gameObject.tag == "Enemy")
        {
            ZombiePuntos();
            disparos++;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            Debug.Log("Colision de bala1");
            if (disparos== 2)
            {
                Debug.Log("Colision de bala");
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                disparos = 0;
            }
        }
    }

    private void ZombiePuntos()
    {
        gameManager = GameObject.Find("GameManager");
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UiManager>();

        gm.ZombiePuntos();
        uim.PrintZombie(gm.GetZombie());
    }
}
