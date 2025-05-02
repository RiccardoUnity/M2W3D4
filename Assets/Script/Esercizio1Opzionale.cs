using UnityEngine;

public class Esercizio1Opzionale : MonoBehaviour
{
    public float PI = 3.14159f;

    void Start()
    {
        Debug.Log((float)(Mathf.Floor(PI * 100))/100f);
    }
}
