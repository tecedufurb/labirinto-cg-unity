using UnityEngine;

public class Mundo : MonoBehaviour {

    public GameObject chao;
    public GameObject jogador;
    public Factory factory;

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

	void Start () {
        factory.CriarObjetoDoMundo(TiposDeObjetos.CHAO, 0, 0);

        for (int x = 0; x < mundo.GetLength(0); x++) {
            for (int y = 0; y < mundo.GetLength(1); y++) {
                factory.CriarObjetoDoMundo((TiposDeObjetos)mundo[x,y], x, y);
            }
        }
    }

    private Vector3 GetPontoInicio() {
        Vector3 posicaoJogador = FindObjectOfType<Inicio>().gameObject.transform.position;
        Vector3 pontoInicio = new Vector3(posicaoJogador.x, posicaoJogador.y + 0.5f, posicaoJogador.z);
        return pontoInicio;
    }
}
