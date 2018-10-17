using UnityEngine;

public class Factory : MonoBehaviour {

    public GameObject parede;
    public GameObject chao;
    public GameObject inicio;
    public GameObject fim;
    public GameObject jogador;

    public void CriarObjetoDoMundo(TiposDeObjetos tipo, int x, int z) {
        switch (tipo) {
            case TiposDeObjetos.PAREDE:
                Instantiate(parede, new Vector3(z, 1, x), Quaternion.identity);
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
