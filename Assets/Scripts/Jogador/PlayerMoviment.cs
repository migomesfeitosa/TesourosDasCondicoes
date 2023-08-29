using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float playerVelocity = 10;
    public float speed = 4.5f;
  //  bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetAxis("Horizontal") == -1)
        {
            Debug.Log("Seta Esquerda");
            //isWalking = true;
            //SetIsWalking(true);
            transform.position -= transform.right * (Time.deltaTime * playerVelocity);
            return;

        }
       // isWalking = true;
       // SetIsWalking(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
