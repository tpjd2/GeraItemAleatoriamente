using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject[] itens;
    [SerializeField] private GameObject referencia;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(
                itens[Random.Range(0, itens.Length)],
                referencia.transform
                );
        }
    }
}
