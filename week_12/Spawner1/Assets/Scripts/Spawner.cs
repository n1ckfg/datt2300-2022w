using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Bomb bombPrefab;
    public float yRange = 1f;
    public float speed = 0.1f;

    void Start() {
        StartCoroutine(spawnBomb());
    }

    void Update() {

    }

    IEnumerator spawnBomb() {
        while (true) {
            Vector3 pos = new Vector3(transform.position.x, Random.Range(-yRange, yRange), transform.position.z);
            Bomb bomb = GameObject.Instantiate(bombPrefab, pos, transform.rotation);
            bomb.speed = new Vector3(-Random.Range(speed / 2f, speed * 2f), 0f, 0f);

            yield return new WaitForSeconds(1f);
        }
    }

}
