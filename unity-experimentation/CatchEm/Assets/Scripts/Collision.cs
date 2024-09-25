using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Unpacked Em!");
    }
}
