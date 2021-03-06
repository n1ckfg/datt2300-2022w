using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Bomb bombPrefab;
    public float spawnInterval = 1f;
    public float yRange = 3f;


    void Start() {
        StartCoroutine(makeBomb());
    }

    void Update() {
        //
    }

    IEnumerator makeBomb() {
        while (true) {
            Vector3 pos = new Vector3(transform.position.x, Random.Range(-3f, 3f), transform.position.z);
            Bomb bomb = GameObject.Instantiate(bombPrefab, pos, transform.rotation);
            bomb.transform.parent = transform;

            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
