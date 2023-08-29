using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalMoviment = Input.GetAxis("Horizontal");
       // Debug.Log(horizontalMoviment);
        transform.position += new Vector3(horizontalMoviment * Time.deltaTime * speed, 0, 0);

    }
}
