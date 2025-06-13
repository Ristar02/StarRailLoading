using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    int number1;
    int number2;

    void Awake()
    {
        number1 = 1;
        number2 = 2;
    }

    void OnEnable()
    {
        number1 += 1;
    }


    // Start is called before the first frame update
    void Start()
    {
        number1 = number2;
    }

    // Update is called once per frame
    void Update()
    {
        if(number1 == number2)
        {

        }
    }
}
