using System.Collections;
using UnityEngine;
using TMPro;

public class Letras : MonoBehaviour
{
    public TextMeshProUGUI texto1, texto2, texto3, texto4;
    public float Humanos;
    public float Monstruos;

    public float delay = 0.05f;

    void Start()
    {
        Humanos = GameManager.instancia.humanos;
        Monstruos = GameManager.instancia.monstruos;
        StartCoroutine(SecuenciaTexto());
    }

    IEnumerator SecuenciaTexto()
    {

        // Guardamos los textos en variables
        string t1 = "Dia 1";
        string t2 = "Humanos : " + Humanos;
        string t3 = "Monstruos : " + Monstruos;
        string t4 = "";

        // TU LÓGICA (sin cambiarla mucho)
        if (Humanos == 0 && Monstruos == 0)
        {
            t4 = "Durante el dia no se presencio nada de vida, solo llegaste a la vida y solo te irás de él,... Los soldados te dan el periodico y ves como los accidentes e incidentes bajan la poblacion del país";
        }
        else if (Humanos > 0 && Humanos < 3 && Monstruos == 0)
        {
            t4 = "Ultimamente no se registro ningun sospechoso... Sin embargo, te sientes como un monstruo por no haber dejado pasar a los que faltaba, en la radio escuchas algunos informes sobre quejas de personas que no pudieron pasar la frontera. Los soldados estan mas pendientes";
        }
        else if (Humanos == 3 && Monstruos == 0)
        {
            t4 = "Entre todas las personas que pasaron, reconoces al hermano de un amigo tuyo, te alegras bastante de que este vivo y haya podido pasar la frontera. Los soldados bajan la guardia y empiezan a hablar entre ellos, desde la ventana escuchas que hablan sobre algunos datos que esconde el gobierno sobre los informes de los dentistas de las personas ¿Que tendra que ver eso con los rumores de los monstruos";
        }
        else if (Humanos == 0 && Monstruos > 0)
        {
            t4 = "Durante el dia no se ha registrado ningun Monstruo, Feliz dia del reves. Uno de los soldados desaparecio de la guardia y el otro dijo que lo ultimo que vio fue su zapado ensangrentado. Que le esta pasando al mundo?!";
        }
        else if (Humanos > 0 && Humanos < 3 && Monstruos > 0)
        {
            t4 = "Durante el dia se ha notificado personas con aspecto sospechoso atacando gente y soldados,entre ellos uno de tu soldados quedo abatido por lo que cuentas solo con uno para la guardia, no sabes porque pero sientes que parte de esto es por tu culpa";
        }
        else if (Humanos == 3 && Monstruos > 0)
        {
            t4 = "En la radio se habla de una asamblea de muchas personas atacando a varios barrios, se empieza a menzionar que pos sus rasgon parecen que no son humanos de verdad y lo empiezan a denominarlos como monstruos. Despues de escuchar la radio decides asomar la cabeza y ves como uno de los soldados se lo lleva el equipo medico por varios ataques recibidos, el otro sigue con su trabajo pero se le ve asustado";
        }

        // Mostrar uno por uno con animación
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