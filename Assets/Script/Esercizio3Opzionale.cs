using UnityEngine;

public class Esercizio3Opzionale : MonoBehaviour
{
    public GameObject gObject;

    public float timeInstantiate = 0.5f;

    private float _middleSide = 10f;

    private void SpawnSphere()
    {
        Instantiate(gObject, new Vector3(Random.Range(-_middleSide, _middleSide), 0f, Random.Range(-_middleSide, _middleSide)), Quaternion.identity);
    }

    void Start()
    {
        InvokeRepeating("SpawnSphere", 0f, timeInstantiate);
    }

}
