using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VIDABac : MonoBehaviour
{
    private Slider slider;
    private void Start() {
        slider = GetComponent<Slider>();
    }
    public void editVBM(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }
    public void editVB(float vida)
    {
        slider.value = vida;
    }
    public void IniciarBarras(float cVida)
    {
        editVB(cVida);
        editVBM(cVida);
    }
}
