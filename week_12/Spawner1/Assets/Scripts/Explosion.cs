using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float lifeTime = 0.5f;

    void Start() {
        StartCoroutine(explode());
    }

    IEnumerator explode() {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.Play();

        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

}
