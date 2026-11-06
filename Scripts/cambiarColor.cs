using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    public Color colorSeleccionado = Color.green;
    Renderer rd;
    Color colorOriginal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Renderer>();
        colorOriginal = rd.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Seleccionar()
    {
        rd.material.color = colorSeleccionado;
    }

    public void Deseleccionar()
    {
        rd.material.color = colorOriginal;
    }
}
