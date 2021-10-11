using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_move : MonoBehaviour
{

    public float speed;
    public bool MoveRight;
    public bool MoveLeft;

    // Update is called once per frame
    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        if(MoveLeft)
        {
            transform.Translate(-2*Time.deltaTime * speed, 0,0);
        }

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
                SceneManager.LoadScene("ProjektX2.0");
        {

        
        }
    }
}
