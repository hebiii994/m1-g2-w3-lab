using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialoghiLogic : MonoBehaviour
{
    public string Dialogo = "(Pupo;Left;happy) Gelato al cioccolato dolce un po salato";
    // Start is called before the first frame update
    void Start()
    {
        if (Dialogo.Contains("(") && Dialogo.Contains(")"))
        {
            int startd = Dialogo.IndexOf('(');
            int endd = Dialogo.IndexOf(')');
            int lenght = endd - startd - 1;
            string detailsDialog = Dialogo.Substring(startd + 1, lenght);
            string [] dialogoArray = detailsDialog.Split(";");
            string mainText = Dialogo.Substring(endd + 1);
            mainText = mainText.Trim();

            if (dialogoArray.Length >= 3)
            {
                Debug.Log(dialogoArray[0]);
                Debug.Log(dialogoArray[1]);
                Debug.Log(dialogoArray[2]);
                Debug.Log(mainText);
                
            }
            else
            {
                Debug.LogError("Errore: La stringa tra parentesi non contiene abbastanza elementi separati da ';'. Contenuto: " + detailsDialog);
            }

        }
        else
        {
            Debug.LogError("Errore: La stringa non contiene parentesi");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
