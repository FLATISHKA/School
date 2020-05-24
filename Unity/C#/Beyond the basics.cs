  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace BeyondTheBasics.Gameplay
{
    public class SampleScript : MonoBehaviour
{
    #region VariableDecalarations

    public int numberToDisplay;
    public int numberToMultiplyBy;

    #endregion VariableDecalarations

    
    void Start()
    {
        SayHelloWORLD();
    }

    private void SayHelloWORLD()
    {
        var randomNumber = Random.Range(0, numberToDisplay);

        for (int i = 0; i < randomNumber; i++)
        {
            Debug.Log("Hello World!");
        }
    }

    private void MultiplyNumber(int numberToMultiply)
    {
        int product = numberToMultiply * numberToMultiplyBy;

        Debug.Log(product);
    }
    // Juuh aika hyvä tutoriaali oli, meen nyt nukkumaan :D
}    
