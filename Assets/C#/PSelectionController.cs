using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSelectionController : MonoBehaviour
{
    public int ShuttleSelected;

    private static PSelectionController instance;

    void Start()
    {
    }

    void Update()
    {
        ShuttleSelected = GameObject.Find("Shuttle").GetComponent<CharacterSelection>().NbShuttle;
    }

    private void Awake()    {        if (instance == null)        {            instance = this;            DontDestroyOnLoad(instance);        }        else        {            Destroy(gameObject);        }    }
}
