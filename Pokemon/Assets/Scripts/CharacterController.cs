using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rigidbody;
	
    // Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetButtonDown;
	}
}
