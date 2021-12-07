using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int p1Points;
    public int p2Points;

    public int p1HouseHealth;
    public int p2HouseHealth;

    public float p1Health = 100f;
    public float p2Health = 100f;

    public bool GameOver = false;

    public void P1PointGain()
    {
        p1Points++;
    }

    public void P2PointGain()
    {
        p2Points++;
    }

    public void P1takeDamage(float i)
    {
        p1Health -= i;

        if (p1Health <= 0f)
        {
            Debug.Log("Player 1 died");

            SceneManager.LoadScene("LooseScreen");

        }
    }

    public void P2takeDamage(float i)
    {
        p2Health -= i;

        if (p2Health <= 0f)
        {
            Debug.Log("Player 2 died");

            SceneManager.LoadScene("LooseScreen");

        }
    }



}
