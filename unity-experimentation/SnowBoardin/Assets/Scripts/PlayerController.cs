using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 startPosition = new Vector2(0, 1);
    [SerializeField] float torqueAmount = 3.0f;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ResetPlayer();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) {
            rb2d.AddTorque(-Input.GetAxis("Horizontal") * torqueAmount);
        }
    }

    public void ResetPlayer() {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        rb2d.velocity = Vector2.zero;
        rb2d.angularVelocity = 0;
    }
}
