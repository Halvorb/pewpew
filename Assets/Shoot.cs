using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject projectile;
    public Transform gun1;
    
    void Update() {
        var firing = Input.GetKeyDown(KeyCode.Space);
        if (firing) {
            Instantiate(projectile, gun1.position, gun1.rotation);
        }
    }
}
