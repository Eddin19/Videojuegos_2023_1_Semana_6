using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 0.2f; // La velocidad de movimiento del enemigo

    // En el método FixedUpdate(), mover el objeto hacia la izquierda a la velocidad especificada
    void FixedUpdate () {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
}
