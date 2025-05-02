using System.Collections.Generic;
using UnityEngine;

public class Esercizio4Opzionale : MonoBehaviour
{
    public GameObject gObject;
    private GameObject _newGObject;

    public float timeAddList = 0.5f;
    public float timeInstantiateList = 2f;

    List<GameObject> listGObject = new List<GameObject>();

    private float _middleSide = 10f;
    private Color[] _colorArray = {Color.red, Color.yellow, Color.green, Color.cyan};
    private Color _color;

    private void SpawnSphere()
    {
        _color = _colorArray[Random.Range(0, _colorArray.Length)];

        foreach (GameObject obj in listGObject)
        {
            _newGObject = Instantiate(obj, new Vector3(Random.Range(-_middleSide, _middleSide), 0f, Random.Range(-_middleSide, _middleSide)), Quaternion.identity);
            _newGObject.GetComponent<MeshRenderer>().material.color = _color;
        }
    }

    private void CreateListSpawSphere()
    {
        listGObject.Add(gObject);
    }

    void Start()
    {
        InvokeRepeating("CreateListSpawSphere", 0f, timeAddList);
        InvokeRepeating("SpawnSphere", timeInstantiateList, timeInstantiateList);
    }

}
