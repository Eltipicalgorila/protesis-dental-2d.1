using UnityEngine;

public class BotonDejarPasar : MonoBehaviour
{
    public ControlFrontera control;
    public Persona personaActual;
    public void DejarPasar()
    {
        control.DejarPasar(personaActual);
    }

}
