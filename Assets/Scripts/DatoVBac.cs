using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DatoVBac : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    private float vidaGe = 0;
    // Start is called before the first frame update
    private void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }
    
    public void editDVBM(float vidaMaxima)
    {
        vidaGe = vidaMaxima;
        textMeshPro.text = vidaGe + "/" + vidaGe;
    }
    public void editDVB(float vida)
    {
        textMeshPro.text = vida + "/" + vidaGe;
        Debug.Log("Cambio de vida:" + textMeshPro.textInfo);
    }
    public void IniciarBarras(float cVida)
    {
        editDVB(cVida);
        editDVBM(cVida);
    }
}
