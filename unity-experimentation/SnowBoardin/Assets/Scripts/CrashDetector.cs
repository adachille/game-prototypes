using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            Debug.Log("Player has crashed!");
            GetComponent<PlayerController>().ResetPlayer();
        }
        Debug.Log("Player crashed into non-ground object!");
    }
}
