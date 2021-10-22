using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    void MudarCena (string Game)
    {     
        SceneManager.LoadScene(Game);
    }

    public void JogarJogo ()
    {
        MudarCena("Game");
    }

}
