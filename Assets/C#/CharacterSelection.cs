using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{

    public RawImage Character;

    public Texture Shuttle1;       //1
    public Texture Shuttle2;       //2
    public Texture Shuttle3;       //3
    public Texture ShuttleSecret;  //4

    public Button NextBttn;
    public Button PreviousBttn;

    public int NbShuttle;

    bool IsCheatActivated = false;

    void Start()
    {
        NbShuttle = 1;
    }

    void Update()
    {
        switch (NbShuttle)
        {
            case 1:
                Character.texture = Shuttle1;
                break;
            case 2:
                Character.texture = Shuttle2;
                break;
            case 3:
                Character.texture = Shuttle3;
                break;
            case 4:
                Character.texture = ShuttleSecret;
                break;

        }

        if (Input.GetKeyDown(KeyCode.M) && Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Y))
        {
                IsCheatActivated = true;
        }
    }

    public void Next()
    {
        if (IsCheatActivated)
        {
            switch (NbShuttle)
            {
                case 1:
                    NbShuttle = 2;
                    break;
                case 2:
                    NbShuttle = 3;
                    break;
                case 3:
                    NbShuttle = 4;
                    break;
                case 4:
                    NbShuttle = 1;
                    break;

            }
        }
        if (!IsCheatActivated)
        {
            switch (NbShuttle)
            {
                case 1:
                    NbShuttle = 2;
                    break;
                case 2:
                    NbShuttle = 3;
                    break;
                case 3:
                    NbShuttle = 1;
                    break;

            }
        }

    }

    public void Previous()
    {
        if (IsCheatActivated)
        {
            switch (NbShuttle)
            {
                case 1:
                    NbShuttle = 4;
                    break;
                case 2:
                    NbShuttle = 1;
                    break;
                case 3:
                    NbShuttle = 2;
                    break;
                case 4:
                    NbShuttle = 3;
                    break;
            }
        }
        if (!IsCheatActivated)
        {
            switch (NbShuttle)
            {
                case 1:
                    NbShuttle = 3;
                    break;
                case 2:
                    NbShuttle = 1;
                    break;
                case 3:
                    NbShuttle = 2;
                    break;

            }
        }
    }
}
