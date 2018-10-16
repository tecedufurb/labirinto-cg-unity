using UnityEngine;

public class Mundo : MonoBehaviour {

    public GameObject chao;
    public GameObject parede;
    public GameObject inicio;
    public GameObject fim;
    public GameObject jogador;

    public byte[,] mundo = new byte[,] {
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 1, 2, 1, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 3, 0, 0, 0, 0, 0, 1 },
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

	// Use this for initialization
	void Start () {
        Instantiate(chao);
        for (int j = 0; j < mundo.GetLength(1); j++) {
            for (int i = 0; i < mundo.GetLength(0); i++) {
                switch(mundo[i, j]) {
                    case 1:
                        Instantiate(parede, new Vector3(j, 1, i), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(inicio, new Vector3(j, 0.5f, i), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(fim, new Vector3(j, 0.5f, i), Quaternion.identity);
                        break;
                }
            }
        }

        Vector3 posicaoJogador = FindObjectOfType<Inicio>().gameObject.transform.position;
        Vector3 novaPosicao = new Vector3(posicaoJogador.x, posicaoJogador.y + 0.5f, posicaoJogador.z);
        Instantiate(jogador, novaPosicao, Quaternion.identity);
    }
}
