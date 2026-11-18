using System;
using UnityEngine;
public class CanvasSwapper : MonoBehaviour
{
    [SerializeField] private GameObject currentCanva;
    public void ChangeCanva(GameObject reference) 
    {
        if (reference == currentCanva) return;

        if(currentCanva != null)
        currentCanva.SetActive(false);
        currentCanva = reference;
        currentCanva.SetActive(true);
    }
}
