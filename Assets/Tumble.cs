using UnityEngine;

public class Tumble : MonoBehaviour {
    private void Start() {
        var body = GetComponent<Rigidbody>();
        body.AddTorque(Random.insideUnitSphere * 15f);
    }
}