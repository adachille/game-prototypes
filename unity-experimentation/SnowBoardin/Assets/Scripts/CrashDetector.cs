using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            Debug.Log("Player has crashed!");
            SceneManager.LoadScene(0);
        }
        Debug.Log("Player crashed into non-ground object!");
    }
}
