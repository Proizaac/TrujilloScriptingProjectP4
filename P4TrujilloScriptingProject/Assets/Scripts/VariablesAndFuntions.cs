using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFuntions : MonoBehaviour
{
    public int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        //run my variable thru my function
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //create the mulitiply by two function
    int MultiplyByTwo(int number)
    {
        //create a local varibale 
        int result;

        //multiply the input number by 2
        result = number * 2;

        //return the value
        return result;
 
   }
    
 }