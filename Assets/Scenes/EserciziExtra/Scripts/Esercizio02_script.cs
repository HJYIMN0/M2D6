using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COLORI
{
    GIALLO,
    ROSSO,
    VERDE,
    BLU
}

public class Esercizio02_script : MonoBehaviour
{
    public COLORI coloreAttuale = COLORI.GIALLO;
    private GameObject sphere;
    void CambiaMateriale()
    {
        Renderer renderer = GetComponent<sphere>();

    }


    // Start is called before the first frame update
    void Start()
    {
        sphere = gameObject.Find("Sphere");
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
