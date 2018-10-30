using UnityEngine;

/// <summary>
/// Represents the end of the maze. 
/// When the player reaches this point the game is ended.
/// </summary>
public class End : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            other.gameObject.GetComponent<Player>().CanWalk = false;
            Debug.Log("Game Over!");
        }
            
    }

}
