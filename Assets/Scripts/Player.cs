using UnityEngine;

/// <summary>
/// Handles the player movement based in the horizontal and vertical inputs.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    private const float moveSpeed = 3;
    private const float rotateSpeed = 120f;
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
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, x, 0);
    }

    private void MovePlayer() {
        if (!CanWalk)
            return;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0, 0, z);
    }
}
