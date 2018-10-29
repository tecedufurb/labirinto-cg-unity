using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    private const float move_speed = 3;
    private const float rotate_speed = 120f;
    private bool canWalk = false;

    public bool CanWalk {
        get {
            return canWalk;
        }
        set {
            canWalk = value;
        }
    }

    void FixedUpdate() {
        MovePlayer();
        RotatePlayer();
    }

    private void RotatePlayer() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotate_speed;
        transform.Rotate(0, x, 0);
    }

    private void MovePlayer() {
        if (!CanWalk)
            return;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * move_speed;
        transform.Translate(0, 0, z);
    }
}
