using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax = 10;
    // Start is called before the first frame update
    void Start()
    {
        List<int> list = new List<int>(numeroMax);
        

        for (int i = 0; i <= numeroMax; i++)
        {
            int insertInto = i % 3;

            switch(insertInto)
            {
                case 0:
                    list.Insert(0, i);
                    break;
                case 1:
                    list.Add(i);
                    break;
                case 2:
                    int middleIndex = list.Count / 2;
                    list.Insert(middleIndex, i);
                    break;
            }

            Debug.Log($"Contenuto lista: [{string.Join(", ", list)}]");
          
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
