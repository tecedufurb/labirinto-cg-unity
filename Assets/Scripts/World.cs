using System.Collections;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class World : MonoBehaviour {

    [SerializeField] private Factory factory;
    public static World instance = null;

    /// <summary>
    /// Stores the position of the objects in the world.
    /// Each position contains a number that represents a type of object. 
    /// All the possible types are contained in the ObjectType enum.
    /// </summary>
    private int[,] worldMatrix = new int[,] {
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
        StartCoroutine(CreateMaze());
    }

    /// <summary>
    /// Runs through the elements of the world_matrix, calling a function
    /// from the Factory class that creates an specific object.
    /// </summary>
    private IEnumerator CreateMaze() {
        factory.CreateObjectOfTheWorld(ObjectTypes.GROUND, 0, 0);

        WaitForSeconds delay = new WaitForSeconds(0.01f);
        for (int x = 0; x < worldMatrix.GetLength(0); x++) {
            for (int y = 0; y < worldMatrix.GetLength(1); y++) {
                #if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE
                    factory.CreateObjectOfTheWorld((ObjectTypes)worldMatrix[x, y], x, y);
                #endif
                yield return delay;
            }
        }
        FindObjectOfType<Player>().CanWalk = true;
    }
}