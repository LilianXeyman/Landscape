using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public Camera[] camaras; //Esto es un array de camaras que nos permitir� hacer el cambio de las escenas de la c�mara
    int cameraActual = 0;//Variable para indicar en qu� c�mara estas
    // Start is called before the first frame update
    void Start()
    {
        foreach (Camera cam in camaras) //Por cada camara en el array de camaras
        { 
            cam.gameObject.SetActive(false); //Desactiva todas las c�maras nada m�s empezar
        }
        if (camaras.Length > 0)//Activas la primera c�mara ya que al tratarse de un array siempre va a haber m�s de una c�mara
        {
            camaras[0].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Si toco la tecla 1 va a la camara 0, si toco la tecla 2 va a la camara 1 y si toco la tecla 3 va a la camara 2 del array. Hacer bucle?
        for (int i = 0; i < camaras.Length; i++)
        {
            if (i > camaras.Length)
            {
                i = 0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))//Dependiendo del numero del array te marcara un n�mero u otro
            {
                SwitchCamera(i);//Pasa a SwitchCamera el numero del array en el que estamos y por consiguiente la camara
                break;
            }
        }
    }
    void SwitchCamera(int index)
    {
        if (camaras.Length > 0 && cameraActual >= 0 && cameraActual < camaras.Length) //Desactivas la camara activa
        {
            camaras[cameraActual].gameObject.SetActive(false);
        }
        if (index >= 0 && index < camaras.Length)
        {
            camaras[index].gameObject.SetActive(true);
        }
        cameraActual = index;
    }
}
