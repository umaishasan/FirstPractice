using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    /*public AudioSource audiosource;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.fanRotate();
    }

    public void fanRotate()
    {
        transform.Rotate(Vector3.up * 50);
    }


    //recursive loop lage ga
    /*  void fanSound()
      {
          audiosource = gameObject.GetComponent<AudioSource>();
          audiosource.l
          for (int i = 0; i > audiosource.clip.length; i++)
          {
              audiosource.Play();
          }
      }*/
}
