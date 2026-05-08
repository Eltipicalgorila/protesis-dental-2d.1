using UnityEngine;

public class VerInformacion : MonoBehaviour
{
   public bool Modo = false;
    public GameObject Informativo, tutorial;
    void Start()
    {
        
    }

    void Update()
    {
        if (Modo == false)
        {
            Informativo.gameObject.SetActive(false);
            tutorial.gameObject.SetActive(true);
        }
        if (Modo == true)
        {
            Informativo.gameObject.SetActive(true);
            tutorial.gameObject.SetActive(false);
        }
    }
    public void Boton()
    {
        Debug.Log("L e di al boton");
        if (Modo == true)
        {
            Modo = false;
        }
        else if (Modo == false) { Modo = true; }
    
    }
}
