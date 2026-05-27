using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverLugar : MonoBehaviour
{
    public GameObject Escritorio, Habitacion, Ventana, NoDormir;
    public ControlFrontera NumPersonas;
    public string NivelPasar;
    void Start()
    {
        NoDormir.gameObject.SetActive(false);
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
            StartCoroutine(NoPuedesDormir());
        }
        else 
        {
            SceneManager.LoadScene(NivelPasar);
        }
    }
    IEnumerator NoPuedesDormir ()
    {
        NoDormir.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        NoDormir.gameObject.SetActive(false);
    }
}
