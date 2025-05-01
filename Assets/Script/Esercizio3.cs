using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    //Essendo un'operazione complessa specifico al meglio la struttura della stringa
    [TextArea(2, 10)]
    [Tooltip("Utilizzare la seguente struttura: (nomePersonaggio;attributo0;attributoX) Quello che dice")]
    public string scriptString = "(Studente;Centrale;XD) Non ho capito l'esercizio prof";

    //Array di stringhe contenente i vari pezzi di scriptString (super ottimizzato)
    private string[] _piecesString;

    void Start()
    {
        //Controllo se scriptString contiene dei caratteri
        if (string.IsNullOrEmpty(scriptString))
        {
            Debug.LogError("Script String è vuota o null, inserire del testo come da formatazione, quindi avviare il gioco");
        }
        else
        {
            //Controllo se scriptString contiene i caratteri speciali richiesti
            if (scriptString.Contains('(') && scriptString.Contains(')'))
            {
                //Controllo se scriptString contiene degli attributi
                if (scriptString.Contains(';'))
                {
                    //Faccio in modo che quando vado ad usare .Split mi venga generato un array grande quanto mi serve per non doverne usare altri
                    scriptString = scriptString.Insert(scriptString.IndexOf(')'), ";");
                    //Divido solo la stringa tra parentesi tonde
                    _piecesString = scriptString.Split(')')[0].Split(';');
                    //Sovrascrivo l'ultima stringa usata come segnaposto
                    _piecesString[_piecesString.Length - 1] = scriptString.Split(')')[1];
                }
                else
                {
                    //Comunico che non ci sono attributi e faccio lo .Split
                    Debug.LogWarning("Script String non contiene attributi");
                    _piecesString = scriptString.Split(')');
                }

                //Rimuovo il primo carattere non necessario
                _piecesString[0] = _piecesString[0].Trim('(');   //So che toglie tutte le '(' della stringa, ma ce ne deve essere solo una
                _piecesString[_piecesString.Length - 1] = _piecesString[_piecesString.Length - 1].TrimStart();
                    
                //Mostro le varie stringhe che compongono scriptString
                foreach (string piece in _piecesString)
                {
                    Debug.Log(piece);
                }
            }
            //scriptString non contiene le parentesi tonde
            else
            {
                Debug.LogError("Script String non contiene ( e ), inserire del testo come da formatazione, quindi avviare il gioco");
            }
        }
    }
}
