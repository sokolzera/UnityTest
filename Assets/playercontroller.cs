using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //wtchelenie sterowania w pionie
        float vertical = Input.GetAxis("Vertical");
        //wychylenie w poziomie
        float horizontal = Input.GetAxis("Horizontal");

        //poka¿ w konsoli
        Debug.Log("Wychylenie w pionie:" +vertical.ToString()
            + "w poziomie: " +horizontal);
    }
}
