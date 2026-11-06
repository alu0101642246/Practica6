using UnityEngine;
using TMPro;

public class actualizarUI : MonoBehaviour
{
    public TMP_Text texto;
    int vecesAgarrado = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Agarrar()
    {
        vecesAgarrado++;
        texto.text = "El yunque fue agarrado " + vecesAgarrado + " veces";
    }
}
