using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaPontuacao : MonoBehaviour
{
    public GameObject efeitoBola;
    void Start() {
        efeitoBola.SetActive(false);
    }
    void OnTriggerEnter(Collider outroCollider) {
        if(outroCollider.GetComponent<Bola>() != null){
            Debug.Log("Fez ponto");
            efeitoBola.SetActive(true);
        }
    }
}
