using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {


    public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W)) { MoveForward(); }

        if (Input.GetKey(KeyCode.A)) { MoveLeft(); }

        if (Input.GetKey(KeyCode.S)) { MoveBackward();  }

        if (Input.GetKey(KeyCode.D)) { MoveRight(); }
                                                                                          
      
    }

    private void MoveForward() { transform.Translate(0, 0, speed * Time.deltaTime); }

    private void MoveBackward() { transform.Translate(0, 0, -speed * Time.deltaTime); }

    private void MoveLeft() { transform.Translate(-speed * Time.deltaTime, 0, 0); }

    private void MoveRight() { transform.Translate(speed * Time.deltaTime, 0, 0); }
}
