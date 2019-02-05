using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public string _printText;
    public GameObject cube;
    public int amount;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void printText()
    {
        print(_printText);
        
    }

    public void playSound()
    {
        GetComponent<AudioSource>().Play();
    }

    public void instantiateCube()
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(cube, transform.position, Quaternion.identity);
        }
    }

    public void soundSpawn()
    {
        GetComponent<AudioSource>().Play();
        for (int i = 0; i < amount; i++)
        {
            Instantiate(cube, transform.position, Quaternion.identity);
        }
    }
}
