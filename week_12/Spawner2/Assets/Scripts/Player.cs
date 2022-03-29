using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpAmount = 1;

    Rigidbody2D rb;
    Animator ctl;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        ctl = GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Jumping");
            setJump(true);
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }

    public void setJump(bool b) {
        ctl.SetBool("Jump", b);
    }

    public void setHit() {
        ctl.SetTrigger("Hit");
    }

}
