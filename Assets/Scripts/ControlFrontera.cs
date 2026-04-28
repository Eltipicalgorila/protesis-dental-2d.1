using System.Collections.Generic;
using UnityEngine;

public class ControlFrontera : MonoBehaviour
{
    public float humanosEntraron, monstruosEntraron;

    public GameObject[] personas;
    public GameObject[] imagenes;
    private int indiceActual = 0;
    public int personaActual = 0;

    void Start()
    {
        // Activamos solo la primera persona
        if (personas.Length > 0)
            personas[personaActual].SetActive(true);
    }

    public void DejarPasar()
    {
        if (personaActual >= personas.Length) return;

        GameObject persona = personas[personaActual];

        // Procesar si es humano o monstruo
        if (persona.CompareTag("Humano"))
        {
            humanosEntraron++;
            Debug.Log("Entró un HUMANO");
        }
        else
        {
            monstruosEntraron++;
            Debug.Log("⚠️ Entró un MONSTRUO");
        }

        persona.SetActive(false);

        personaActual++;

        if (personaActual < personas.Length)
        {
            personas[personaActual].SetActive(true);
        }
        else
        {
            GameManager.instancia.humanos = humanosEntraron;
            GameManager.instancia.monstruos = monstruosEntraron;
        }
        imagenes[indiceActual].SetActive(false);
        indiceActual++;
        imagenes[indiceActual].SetActive(true);
    }
    public void NoDejarPasar()
    {
        if (personaActual >= personas.Length) return;

        GameObject persona = personas[personaActual];

        // Procesar si es humano o monstruo

        persona.SetActive(false);

        personaActual++;

        if (personaActual < personas.Length)
        {
            personas[personaActual].SetActive(true);
        }
        else
        {
            GameManager.instancia.humanos = humanosEntraron;
            GameManager.instancia.monstruos = monstruosEntraron;
        }
        imagenes[indiceActual].SetActive(false);
        indiceActual++;
        imagenes[indiceActual].SetActive(true);
    }
}