using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Explosion explosionPrefab;
    public float spawnInterval = 1f;
    public float yRange = 0.4f;

    private void Start() {
        StartCoroutine(doSpawn());
    }

    private IEnumerator doSpawn() {
        while (true) {
            yield return new WaitForSeconds(spawnInterval);

            Vector3 pos = new Vector3(transform.position.x, Random.Range(transform.position.y - yRange, transform.position.y + yRange), transform.position.z);
            Explosion explosion = Instantiate(explosionPrefab, pos, transform.rotation);
            explosion.transform.parent = transform;
        }
    }

}
