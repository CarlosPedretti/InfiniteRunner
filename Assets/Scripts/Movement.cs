using UnityEngine;
using System.Collections;


public class Movement : MonoBehaviour
{
    public float speed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 movedirection;



    private bool groundedPlayer;




    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            GameManager.Instance.ShowGameOverScreen();
            Time.timeScale = 0f;
        }
    }




    void Update()
    {


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movedirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movedirection * speed * Time.deltaTime);
    }
}