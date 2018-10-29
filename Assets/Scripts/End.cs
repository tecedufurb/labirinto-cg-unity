using UnityEngine;

/// <summary>
/// Classe teste
/// </summary>
public class End : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            other.gameObject.GetComponent<Player>().CanWalk = false;
            Debug.Log("Game Over!");
        }
            
    }

}
