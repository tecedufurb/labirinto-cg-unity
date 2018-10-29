using UnityEngine;

public class Factory : MonoBehaviour {

    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject end;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject wallsWrapper;

    public void CriarObjetoDoMundo(ObjectsType type, int x, int z) {
        switch (type) {
            case ObjectsType.WALL:
                // TODO: como usa o Quaternion
                GameObject wallTemp = Instantiate(wall, new Vector3(z, 1.5f, x), Quaternion.identity);
                wallTemp.name = string.Format("{0}({1}, {2})", wall.name, x+1, z+1);
                wallTemp.transform.parent = wallsWrapper.transform;
                break;
            case ObjectsType.START:
                Instantiate(start, new Vector3(z, 0.5f, x), Quaternion.identity);
                Instantiate(player, new Vector3(z, 1f, x), Quaternion.identity);
                break;
            case ObjectsType.END:
                Instantiate(end, new Vector3(z, 0.5f, x), Quaternion.identity);
                break;
            case ObjectsType.GROUND:
                Instantiate(ground);
                break;
        }
    }
}
