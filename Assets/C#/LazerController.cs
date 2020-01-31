using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField] private GameObject Lazer;
    public GameObject LazerPublic;
    public GameObject SpaceShip;

    private Vector2 LazerPosition;

    private bool HasShooted=false;
    float timer = 0;
    float x;

    void Start()
    {
        LazerPosition = new Vector2(SpaceShip.transform.position.x - 1f, SpaceShip.transform.position.y -0.16f);
        Lazer.transform.position = LazerPosition;
        x = SpaceShip.transform.position.x;
        Lazer = LazerPublic;

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space)&&HasShooted==false)
        {
            
            LazerPosition = new Vector2(SpaceShip.transform.position.x +1f, SpaceShip.transform.position.y + (-0.16f));
            timer = 0;
            HasShooted = true;
            Lazer = Instantiate(Lazer, LazerPosition, Quaternion.identity);
        }

        if (HasShooted==true)
        {
            LazerPosition.x += 10*Time.deltaTime;
            Lazer.transform.position = LazerPosition;
            timer+=50*Time.deltaTime;
        }
        if (timer >= 10)
        {
            HasShooted = false;
        }
    }
}
