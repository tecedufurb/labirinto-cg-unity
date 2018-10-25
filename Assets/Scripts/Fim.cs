using UnityEngine;

/// <summary>
/// Classe teste
/// </summary>
public class Fim : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            other.gameObject.GetComponent<Jogador>().PodeAndar = false;
            Debug.Log("Fim de jogo!");
        }
            
    }

}
