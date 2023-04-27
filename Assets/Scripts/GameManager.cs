using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private PlayerController playerController;

    private int Puntaje = 0;
    private int Vidas = 2;
    private int Zombie = 0;
    // Start is called before the first frame update

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        playerController.muerteJugador += ActivarMenu;
    }
    private void ActivarMenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
    }

    public void GanarPuntos() {
        Puntaje +=5;
    }
    //
    public void PerderPuntos()
    {
        Puntaje -= 1;
    }

    public void PerderVidas() {
        if(Vidas > 0)
            Vidas -= 1;
    }
    public void ZombiePuntos()
    {
        Zombie += 1;
    }
    public int GetZombie()
    {
        return Zombie;
    }

    public int GetPuntaje() {
        return Puntaje;
    }

    public int GetVidas() {
        return Vidas;
    }
}
