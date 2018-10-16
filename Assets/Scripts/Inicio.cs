using UnityEngine;

public class Inicio : MonoBehaviour {

    public static Inicio instance;

    void Awake() {
        if (!instance) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
