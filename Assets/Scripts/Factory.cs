using UnityEngine;

/// <summary>
/// Handles the instantiation ofthe objects in the scene.
/// </summary>
public class Factory : MonoBehaviour {

    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject end;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject wallsWrapper;

    /// <summary>
    /// Instantiates the specified object in the scene.
    /// </summary>
    /// <param name="type">The type of the object to be created.</param>
    /// <param name="x">The x position.</param>
    /// <param name="z">The z position.</param>
    public void CreateObjectOfTheWorld(ObjectTypes type, int x, int z) {
        switch (type) {
            case ObjectTypes.WALL:
                // TODO: como usa o Quaternion
                GameObject wallTemp = Instantiate(wall, new Vector3(z, 2.5f, x), Quaternion.Euler(90, 0, 0));
                wallTemp.name = string.Format("{0}({1}, {2})", wall.name, x+1, z+1);
                wallTemp.transform.parent = wallsWrapper.transform;
                break;
            case ObjectTypes.START:
                Instantiate(start, new Vector3(z, 0.5f, x), Quaternion.identity);
                Instantiate(player, new Vector3(z, 1f, x), Quaternion.identity);
                break;
            case ObjectTypes.END:
                Instantiate(end, new Vector3(z, 0.5f, x), Quaternion.identity);
                break;
            case ObjectTypes.GROUND:
                Instantiate(ground);
                break;
        }
    }
}
