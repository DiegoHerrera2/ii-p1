using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Hola, soy un " + gameObject.name + " con etiqueta: " + gameObject.tag);
    }
}
