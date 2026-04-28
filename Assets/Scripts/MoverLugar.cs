using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverLugar : MonoBehaviour
{
    public GameObject Escritorio, Habitacion, Ventana;
    public ControlFrontera NumPersonas;
    void Start()
    {
    }


    public void BotonEscritorio ()
    {
        Escritorio.gameObject.SetActive(true);
        Habitacion.gameObject.SetActive(false);
        Ventana.gameObject.SetActive(false);
    }
    public void BotonVentana()
    {
        Escritorio.gameObject.SetActive(false);
        Habitacion.gameObject.SetActive(false);
        Ventana.gameObject.SetActive(true);
    }
    public void BotonHabitacion()
    {
        Escritorio.gameObject.SetActive(false);
        Habitacion.gameObject.SetActive(true);
        Ventana.gameObject.SetActive(false);
    }
    public void BotonCama()
    {
        if (NumPersonas.personaActual < NumPersonas.personas.Length)
        {
            Debug.Log("Necesitas terminar tu trabajo");
        }
        else 
        {
            SceneManager.LoadScene("Primer Final");
        }
    }
}
