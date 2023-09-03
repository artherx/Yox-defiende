using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DatoVBac : MonoBehaviour
{
    private TextMeshPro textMeshPro;
    // Start is called before the first frame update
    private void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }
    
    public void editVBM(float vidaMaxima)
    {
        textMeshPro.text = vidaMaxima + "/" + vidaMaxima;
    }
    public void editVB(float vida)
    {
        textMeshPro.text = vida + "/" + 150;
        Debug.Log("Cambio de vida:" + vida);
    }
    public void IniciarBarras(float cVida)
    {
        editVB(cVida);
        editVBM(cVida);
    }
}
