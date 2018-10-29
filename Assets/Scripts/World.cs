using System.Collections;
using UnityEngine;

public class World : MonoBehaviour {

    public Factory factory;
    public static World instance = null;

    public int[,] world_matrix = new int[,] {
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
        StartCoroutine(CreateWorld());
    }

    /// <summary>
    /// Run through the 'world' matrix defined in this class, calling the function CreateObjectOfTheWorld
    /// from the Factory class, passing the element of the matrix as parameter.
    /// </summary>
    /// <returns></returns>
    private IEnumerator CreateWorld() {
        factory.CriarObjetoDoMundo(ObjectsType.GROUND, 0, 0);

        WaitForSeconds delay = new WaitForSeconds(0.01f);
        for (int x = 0; x < world_matrix.GetLength(0); x++) {
            for (int y = 0; y < world_matrix.GetLength(1); y++) {
                #if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE
                    factory.CriarObjetoDoMundo((ObjectsType)world_matrix[x, y], x, y);
                #endif
                yield return delay;
            }
        }
        FindObjectOfType<Player>().CanWalk = true;
    }
}