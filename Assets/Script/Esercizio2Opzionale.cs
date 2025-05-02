using UnityEngine;

public class Esercizio2Opzionale : MonoBehaviour
{
    public enum COLORI
    {
        ROSSO = 1,

        VERDE = 4,

        VIOLA = 7
    }

    [Header("Cambia il colore, poi spunta esegui")]
    public COLORI colori = COLORI.ROSSO;
    public bool esegui;

    private Material _material;
    private Color _rosso = Color.red;
    private Color _verde = Color.green;
    private Color _viola = new Color(0.5f, 0f, 1f, 1f);

    private void CambioColore()
    {
        switch (colori)
        {
            case COLORI.ROSSO:
                _material.color = _rosso;
                break;
            case COLORI.VERDE:
                _material.color = _verde;
                break;
            case COLORI.VIOLA:
                _material.color = _viola;
                break;
        }
    }

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        CambioColore();
    }

    void Update()
    {
        if (esegui)
        {
            esegui = false;
            CambioColore();
        }
    }
}
