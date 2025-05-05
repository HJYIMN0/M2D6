using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio03_script : MonoBehaviour
{

    public string s1 = "(Aragorn;left;angry) Che siate attento, non è un gingillo quello che portate!";
    public string s2 = "(Gandalf;right) Uno stregone non è mai in ritardo, arriva precisamente quando intende farlo.";
    // Start is called before the first frame update
    void Start()
    {
        string s3 = s1.Replace("(", "");
        s3 = s3.Replace(") ", ";");
        string[] stringhe = s3.Split(";");
        if (s1.IndexOf("(") == 0 && s1.IndexOf(")") != -1)
        {
         
            for (int i = 0; i < stringhe.Length; i++)
            {
                Debug.Log(stringhe[i]);
            }
        }
        else 
        {
            Debug.Log("ERRORE! Il testo non è scritto nel formato corretto!");
        }

        string s4 = s2.Replace("(","");
        s4 = s4.Replace(") ", ";");    
        stringhe = s4.Split(";");
        if (s2.IndexOf("(") == 0 && s2.IndexOf(")") != -1)
        {
            for (int i = 0; i < stringhe.Length; i++)
            {
                Debug.Log(stringhe[i]);
            }
        }
        else 
        {
            Debug.Log("ERRORE! Il testo non è scritto nel formato corretto!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
