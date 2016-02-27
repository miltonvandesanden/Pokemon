using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Transform transform;

	// Use this for initialization
	void Start ()
    {
        transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveX = 0.0f;
        float moveZ = 0.0f;
        float moveY = 0.0f;

        if (Input.GetKeyDown("a"))
        {
            moveX = -1.0f;
        }

        if(Input.GetKeyDown("d"))
        {
            moveX = 1.0f;
        }

        if(Input.GetKeyDown("s"))
        {
            moveZ = -1.0f;
        }

        if(Input.GetKeyDown("w"))
        {
            moveZ = 1.0f;
        }

        Vector3 move = new Vector3(moveX, moveY, moveZ);

        transform.Translate(move);
	}
}
