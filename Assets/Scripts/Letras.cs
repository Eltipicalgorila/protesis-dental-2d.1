using System.Collections;
using UnityEngine;
using TMPro;
public class Letras : MonoBehaviour
{
    public TextMeshProUGUI[] textos; // lista de textos
    public string[] mensajes; // lista de mensajes
    public float delay = 0.08f;

    void Start()
    {
        StartCoroutine(Secuencia());
    }

    IEnumerator Secuencia()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            yield return StartCoroutine(ShowText(textos[i], mensajes[i]));
            yield return new WaitForSeconds(0.3f); // pequeña pausa
        }
    }

    IEnumerator ShowText(TextMeshProUGUI textComponent, string fullText)
    {
        textComponent.text = "";

        foreach (char c in fullText)
        {
            textComponent.text += c;
            yield return new WaitForSeconds(delay);
        }
    }
}