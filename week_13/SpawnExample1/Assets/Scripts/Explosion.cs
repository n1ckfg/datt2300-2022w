using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float lifetime = 2f;
    public float speed = -0.01f;
    public Particles particlesPrefab;

    IEnumerator Start() {
        lifetime = Random.Range(0.8f * lifetime, 1.2f * lifetime);
        speed = Random.Range(0.8f * speed, 1.2f * speed);

        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
        Instantiate(particlesPrefab, transform.position, transform.rotation);
    }

    private void Update() {
        transform.Translate(speed, 0f, 0f);        
    }

}
