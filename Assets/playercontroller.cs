using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 10;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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

        Vector3 movement = new Vector3(vertical, 0, horizontal);

        if(movement.magnitude > 0)
        {
            audioSource.Play();
        } else
        {
            audioSource.Stop();
        }
        
        transform.position += movement * Time.deltaTime * speed;
    }
}
