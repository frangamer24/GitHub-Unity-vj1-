using UnityEngine;
using TMPro;

public class PorductoController : MonoBehaviour
{
    [SerializeField] [Range(10, 2000)]
    private int costo;

    [SerializeField] private TextMeshProUGUI textoProducto;

    private int cantidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cantidad = Random.Range(2, 20);
        ActualizarTexto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comprar()
    {
        if (costo <= 10)
        {
            cantidad++;
            //monedas -= costoChipa;
            ActualizarTexto();
            //ActualizarTextoMonedas();
        }
    }

    private void ActualizarTexto()
    {
        textoProducto.text = "x " + cantidad;
    }
}
