using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    //Creo un enum per tenere traccia della PROSSIMA posizione sulla quale inserire
    enum POSITION
    {
        PRIMO = 0,
        CENTRALE = 1,
        ULTIMO = 2
    }

    public int numberMax;

    //[SerializeField]
    List<int> listNumber = new List<int>();

    //Mi creo una funzione privata per essere più ordinato ...
    private void WriteList(ref List<int> intList)
    {
        //Istanzio le variabili da usare per occupare meno memoria, non è necessario inizializzarle
        int i;
        int j;
        string listInString;
        POSITION position = POSITION.PRIMO;

        //Mi assicuro che numberMax sia maggiore di zero, altrimenti il ciclo non viene eseguito
        numberMax = Mathf.Abs(numberMax);

        for (i = 0; i <= numberMax; i++)
        {
            //Controllo in quale posizione aggiungere il numero successivo e aggiorno position per la PROSSIMA posizione
            switch (position)
            {
                case POSITION.PRIMO:
                    listNumber.Insert(0, i);
                    position = POSITION.ULTIMO;
                    break;
                case POSITION.CENTRALE:
                    listNumber.Insert(i / 2, i);
                    position = POSITION.PRIMO;
                    break;
                case POSITION.ULTIMO:
                    listNumber.Add(i);
                    position = POSITION.CENTRALE;
                    break;
            }

            //Costruisco la stringa da comunicare con Debug.Log()
            listInString = "";
            for (j = 0; j < listNumber.Count; j++)
            {
                listInString += listNumber[j].ToString();
            }

            //Comunico la stringa
            Debug.Log(listInString);
        }
    }

    void Start()
    {
        WriteList(ref listNumber);
    }
}
