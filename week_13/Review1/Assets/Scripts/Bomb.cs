using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public float speed = -0.01f;
    public float lifeTime = 2f;
    public Explosion explosionPrefab;

    private Vector3 screenBounds;
    private Player player;

    private void Start() {
        player = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>();
        speed = Random.Range(speed * 0.8f, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    private void Update() {
        transform.Translate(speed, 0f, 0f);

        if (transform.position.x < -screenBounds.x) {
            player.score++;
            Debug.Log("Score: " + player.score);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        player.setHit();
        GameObject.Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Player hit!");
    }

}