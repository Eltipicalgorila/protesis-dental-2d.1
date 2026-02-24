using UnityEngine;

public class ControlFrontera : MonoBehaviour
{
    public int humanosEntraron;
    public int monstruosEntraron;

    public void DejarPasar(Persona persona)
    {
        if (persona.persona)
        {
            humanosEntraron++;
            Debug.Log("Entró un HUMANO");
        }
        else
        {
            monstruosEntraron++;
            Debug.Log("⚠️ Entró un MONSTRUO");
        }

        // Aquí podrías destruir o mover al NPC
        Destroy(persona.gameObject);
    }
}
