using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform m_Transform;
    Rigidbody2D m_rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        m_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Transform.position += new Vector3(-3 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Transform.position += new Vector3(3 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody2D.velocity += new Vector2(0, 8.5f);

        }


    }
}
}
