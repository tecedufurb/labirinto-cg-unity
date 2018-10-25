using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jogador : MonoBehaviour {

    private float velocidade = 3;
    private bool podeAndar = false;

    public bool PodeAndar {
        get {
            return podeAndar;
        }
        set {
            podeAndar = value;
        }
    }

    void FixedUpdate() {
        Movimentar();
        Rotacionar();
    }

    private void Rotacionar() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        transform.Rotate(0, x, 0);
    }

    private void Movimentar() {
        if (!PodeAndar)
            return;

        float z = Input.GetAxis("Vertical") * Time.deltaTime * velocidade;
        transform.Translate(0, 0, z);
    }
}
