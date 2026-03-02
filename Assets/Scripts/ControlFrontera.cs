using System.Collections.Generic;
using UnityEngine;

public class ControlFrontera : MonoBehaviour
{
    public float humanosEntraron,monstruosEntraron;
    public GameObject[] personas; // Arrastra aquí tus 4 personajes (desactivados)




    public void DejarPasar()
    {
        for (int i = 0; i < personas.Length; i++)
        {
            // Activar la persona
            personas[i].gameObject.SetActive(true);

            // Procesar si es humano o monstruo
            if (personas[i])
            {
                humanosEntraron++;
                Debug.Log("Entró un HUMANO");
            }
            else
            {
                monstruosEntraron++;
                Debug.Log("⚠️ Entró un MONSTRUO");
            }
            personas[i].gameObject.SetActive(false);
        }
    }
}


