using UnityEngine;
using System.Collections;

public class ConventionAndSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is there to tell me the x position of the object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);
    }
    void Update()
    { 
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}