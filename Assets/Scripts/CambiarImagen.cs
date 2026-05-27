using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarImagen : MonoBehaviour
{
    public Image[] imagenes;
    public string nombreEscena;

    private int index = 0;
    private int clicks = 1;

    void Start()
    {
        // Apagar todas
        for (int i = 0; i < imagenes.Length; i++)
        {
            imagenes[i].gameObject.SetActive(false);
        }

        // Mostrar la primera
        if (imagenes.Length > 0)
            imagenes[0].gameObject.SetActive(true);
    }

    public void Cambiar()
    {
        clicks++;

        // Si aún estamos dentro de las 3 imágenes
        if (clicks <= imagenes.Length)
        {
            imagenes[index].gameObject.SetActive(false);

            index++;

            if (index < imagenes.Length)
            {
                imagenes[index].gameObject.SetActive(true);
            }
        }
        else
        {
            // 4º click → cambiar escena
            SceneManager.LoadScene(nombreEscena);
        }
    }
}