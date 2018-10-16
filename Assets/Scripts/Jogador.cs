using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jogador : MonoBehaviour {

    [SerializeField] private float speed;

    void Update() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);
    }
}
