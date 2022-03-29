using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public Vector3 speed;
    public float lifeTime = 2f;
    public Explosion explosionPrefab;

    void Start() {
        speed.x = Random.Range(speed.x * 0.8f, speed.x * 1.2f);
        StartCoroutine(checkAlive());
    }

    void Update() {
        transform.Translate(speed);
    }

    IEnumerator checkAlive() {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        GameObject.Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Player hit!");
    }

}