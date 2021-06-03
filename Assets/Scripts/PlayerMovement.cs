using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform m_Transform;
    Rigidbody2D m_rigidbody2D;

    public Joystick joystick;
    float horizontalMove = 0f;
    public float playerSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        m_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove =  joystick.Horizontal *playerSpeed;

        m_rigidbody2D.AddForce(new Vector2(horizontalMove, 0f));


    }
}
