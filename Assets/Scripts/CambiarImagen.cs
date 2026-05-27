using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CambiarImagen : MonoBehaviour
{
    public Image imagenUI;
    public Sprite[] imagenes;
    public string nombreEscena;

    private int clicks = 1;

    public void AlPulsarBoton()
    {
        if (clicks < imagenes.Length)
        {
            imagenUI.sprite = imagenes[clicks];
            imagenUI.SetNativeSize();
        }
        else
        {
            SceneManager.LoadScene("Nivel1");
        }

        clicks++;
    }
}