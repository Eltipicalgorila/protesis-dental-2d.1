using UnityEngine;

public class VerInformacion : MonoBehaviour
{
   public bool Modo = false;
    public GameObject Informativo;
    void Start()
    {
        
    }

    void Update()
    {
        if (Modo == false)
        {
            Informativo.gameObject.SetActive(false);
        }
        if (Modo == true)
        {
            Informativo.gameObject.SetActive(true);
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
