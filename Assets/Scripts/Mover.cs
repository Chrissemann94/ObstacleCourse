using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


    [SerializeField] float moveSpeed;     // SerializeField: Zeigt Feld in Inspektor an und macht es dort bearbeitbar


    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // Input.GetAxis: Zugriff auf InputManager
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;                       // Time.deltaTime: Macht Bewegung des Objektes Framerate unabhängig
        transform.Translate(xValue, 0, zValue);   // Transform.Translate: Verschiebt Objekt um den Wert der angegebenen Koordinaten
    }
}
