using UnityEngine;
using System.Collections;


public class Movement : MonoBehaviour
{
    public float speed = 0.1f;

     bool LeftMove;
     bool RightMove;



    void Start()
    {
        LeftMove = true;
        RightMove = true;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            GameManager.Instance.ShowGameOverScreen();
            Time.timeScale = 0f;
        }

    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "LeftWall")
        {
            LeftMove = false;

        }
        else
        {
            LeftMove = true;
        }

        if (other.gameObject.tag == "RightWall")
        {
            RightMove = false;

        }
        else
        {
            RightMove = true;
        }
    }



    void Update()
    {

            if (Input.GetKey(KeyCode.A) && LeftMove == true)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);

            }
        

      
            if (Input.GetKey(KeyCode.D) && RightMove == true)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
     
    }


    
}