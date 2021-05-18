using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject projectile;
    public Transform[] guns;
    
    void Update() {
        var firing = Input.GetKeyDown(KeyCode.Space);
        if (firing) {
            foreach (var gun in guns) {
                Instantiate(projectile, gun.position, gun.rotation);    
            }
        }
    }
}
