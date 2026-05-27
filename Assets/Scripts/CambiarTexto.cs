using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CambiarTexto : MonoBehaviour
{
    public TextMeshProUGUI[] textoUI;

    private int index = 0;
    private int clicks = 1;

    void Start()
    {
        // Apagar todas
        for (int i = 0; i < textoUI.Length; i++)
        {
            textoUI[i].gameObject.SetActive(false);
        }

        // Mostrar la primera
        if (textoUI.Length > 0)
            textoUI[0].gameObject.SetActive(true);
    }

    public void Textos()
    {
        clicks++;

        // Si aún estamos dentro de las 3 imágenes
        if (clicks <= textoUI.Length)
        {
            textoUI[index].gameObject.SetActive(false);

            index++;

            if (index < textoUI.Length)
            {
                textoUI[index].gameObject.SetActive(true);
            }
        }
    }
}