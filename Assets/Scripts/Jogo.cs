using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour {

    public static Jogo instance = null;

    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
