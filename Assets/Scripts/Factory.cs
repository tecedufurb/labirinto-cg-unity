using UnityEngine;

public class Factory : MonoBehaviour {

    [SerializeField] private GameObject parede;
    [SerializeField] private GameObject chao;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject fim;
    [SerializeField] private GameObject jogador;
    [SerializeField] private GameObject agrupadorParedes;


    public void CriarObjetoDoMundo(TiposDeObjetos tipo, int x, int z) {
        switch (tipo) {
            case TiposDeObjetos.PAREDE:
                GameObject paredeTemp = Instantiate(parede, new Vector3(z, 1.5f, x), Quaternion.identity);
                paredeTemp.name = string.Format("Parede({0}, {1})", x+1, z+1);
                paredeTemp.transform.parent = agrupadorParedes.transform;
            //TODO: como usa o Quaternion
                break;
            case TiposDeObjetos.INICIO:
                Instantiate(inicio, new Vector3(z, 0.5f, x), Quaternion.identity);
                Instantiate(jogador, new Vector3(z, 1f, x), Quaternion.identity);
                break;
            case TiposDeObjetos.FIM:
                Instantiate(fim, new Vector3(z, 0.5f, x), Quaternion.identity);
                break;
            case TiposDeObjetos.CHAO:
                Instantiate(chao);
                break;
        }
    }
}
