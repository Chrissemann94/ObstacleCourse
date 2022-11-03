using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;    // Greift auf Komponente des Objektes zu und ändert dessen Farbe
            gameObject.tag = "Hit";
        }
        
    }
}
