using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();  
    }

    void MovePlayer(){
        float xValue = -Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(xValue,0,zValue);
    }
}
