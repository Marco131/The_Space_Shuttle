using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SShipController : MonoBehaviour
{
    public GameObject SShip;
    float y;
    float x;

    void Start()
    {
        y = SShip.transform.position.y;
        x = SShip.transform.position.x;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            y += 5 * Time.deltaTime;
            SShip.transform.position = new Vector2(SShip.transform.position.x,y);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            y -= 5 * Time.deltaTime;
            SShip.transform.position = new Vector2(SShip.transform.position.x, y);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 5 * Time.deltaTime;
            SShip.transform.position = new Vector2(x,SShip.transform.position.y);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            x += 5 * Time.deltaTime;
            SShip.transform.position = new Vector2(x, SShip.transform.position.y);
        }
    }
}
