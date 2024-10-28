using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;
    public string groundTag = "Ground";
    // Start is called before the first frame update
    void Start()
    {
        bounceCount = 0;
    }

    void  OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(groundTag))
        {
            bounceCount++;
            Debug.Log("Bounce count: " + bounceCount);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
