using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax = 10;
    List<int> index = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        int state = 0;
        string listaStringa = "";
        
        for (int i = 0; i <= numeroMax; i++) 
        {
            
            if (state == 0)
            {
                index.Insert(0, i);      
                
            }
            else if (state == 1)
            {
                index.Insert(index.Count, i);                
                
            }
            else if (state == 2)
            {
                index.Insert((index.Count/2), i);
                
            }

            listaStringa = ""; 
            foreach (int numero in index)
            {
                listaStringa += numero + ", "; 
            }

          
            Debug.Log(listaStringa);


            state++;
            if (state > 2)
            {
                state = 0;
            }

        }
        Debug.Log(listaStringa);
        

      



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
