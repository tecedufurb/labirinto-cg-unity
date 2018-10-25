using System.Collections;
using UnityEngine;

public class Mundo : MonoBehaviour {

    public Factory factory;
    public static Mundo instance = null;

    public int[,] mundo = new int[,] {
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 2, 1, 3, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 0, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 1, 1, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
    };

    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start () {
        StartCoroutine(CriarMundo());
    }

    private IEnumerator CriarMundo() {
        factory.CriarObjetoDoMundo(TiposDeObjetos.CHAO, 0, 0);

        WaitForSeconds delay = new WaitForSeconds(0.01f);
        for (int x = 0; x < mundo.GetLength(0); x++) {
            for (int y = 0; y < mundo.GetLength(1); y++) {
                factory.CriarObjetoDoMundo((TiposDeObjetos)mundo[x, y], x, y);
                yield return delay;
            }
        }
        FindObjectOfType<Jogador>().PodeAndar = true;
    }
}