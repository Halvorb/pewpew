using System;
using UnityEngine;

public class Shot1 : MonoBehaviour {

    public float speed = 20f;
    public float timeToLive = 2f;

    private void Start() {
        Destroy(gameObject, timeToLive);
    }

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
    }
}
