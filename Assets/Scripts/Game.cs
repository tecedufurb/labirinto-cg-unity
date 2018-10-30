using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages general game stuff such as inputs given by the player.
/// </summary>
public class Game : MonoBehaviour {

    public static Game instance = null;

    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            ReloadCurrentScene();
    }

    private void ReloadCurrentScene() {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
