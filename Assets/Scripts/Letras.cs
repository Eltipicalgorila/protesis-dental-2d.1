using System.Collections;
using UnityEngine;
using TMPro;

public class Letras : MonoBehaviour
{
    public TextMeshProUGUI texto1, texto2, texto3, texto4;
    public float Humanos;
    public float Monstruos;
    public string QueDIA;

    public float delay = 0.05f;

    void Start()
    {
        Humanos = GameManager.instancia.humanos+ Humanos;
        Monstruos = GameManager.instancia.monstruos+Monstruos;
            StartCoroutine(SecuenciaTexto());
    }

    IEnumerator SecuenciaTexto()
    {

       
        string t1 = "Dia " + QueDIA;
        string t2 = "Humanos : " + Humanos;
        string t3 = "Monstruos : " + Monstruos;
        string t4 = "";

      
        if (Humanos == 0 && Monstruos == 0)
        {

            t4 = "Durante el dia no se presencio nada de vida, solo llegaste a la vida y solo te iras de él,... Los soldados te dan el periodico y ves como los accidentes e incidentes bajan la poblacion del pais";
        }
        else if (Humanos > 0 && Humanos < 3 && Monstruos == 0)
        {
            t4 = "Últimamente no se registró ningun monstruo, en la radio escuchas algunos informes sobre quejas de personas que no pudieron pasar la frontera. Los soldados estan mas pendientes";

            t4 = "Durante el dia no se presencio nada de vida, solo llegaste a la vida y solo te iras de el,... Los soldados te dan el periodico y ves como los accidentes e incidentes bajan la poblacion del pais";
        }
        else if (Humanos > 0 && Humanos < 3 && Monstruos == 0)
        {
            t4 = "Ultimamente no se registro ningun monstruo... Sin embargo, te sientes como un monstruo por no haber dejado pasar a los que faltaba, en la radio escuchas algunos informes sobre quejas de personas que no pudieron pasar la frontera. Los soldados estan mas pendientes";

        }
        else if (Humanos == 3 && Monstruos == 0)
        {
            t4 = "Entre todas las personas que pasaron, reconoces al hermano de un amigo tuyo, te alegras bastante de que este vivo y haya podido pasar la frontera. Los soldados bajan la guardia";
        }
        else if (Humanos == 0 && Monstruos > 0)
        {
            t4 = "Durante el dia no se ha registrado ningun monstruo, Feliz dia del reves. Uno de los soldados desaparecio de la guardia y el otro dijo que lo ultimo que vio fue su zapado ensangrentado. ¡¿Que le esta pasando al mundo?!";
        }
        else if (Humanos > 0 && Humanos < 3 && Monstruos > 0)
        {
            t4 = "Durante el dia se ha notificado personas con aspecto monstruoso atacando gente y soldados,asomas a la ventana y te falta 1 soldado";
        }
        else if (Humanos == 3 && Monstruos > 0)
        {

            t4 = "En la radio se habla de una asamblea de varios monstruos atacando, asomas la cabeza y ves que te falta 1 soldado";
        }

        yield return StartCoroutine(EscribirTexto(texto1, t1));
        yield return new WaitForSeconds(0.3f);

        yield return StartCoroutine(EscribirTexto(texto2, t2));
        yield return new WaitForSeconds(0.3f);

        yield return StartCoroutine(EscribirTexto(texto3, t3));
        yield return new WaitForSeconds(0.3f);

        yield return StartCoroutine(EscribirTexto(texto4, t4));
    }

    IEnumerator EscribirTexto(TextMeshProUGUI texto, string mensaje)
    {
        texto.text = "";

        foreach (char c in mensaje)
        {
            texto.text += c;
            yield return new WaitForSeconds(delay);
        }
    }
}