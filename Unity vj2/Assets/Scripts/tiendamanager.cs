using System;
using UnityEngine;
using TMPro;

public class TiendaManager : MonoBehaviour
{
    [SerializeField] private GameObject panelGestion;
    [SerializeField] private TextMeshProUGUI textoChipa;
    [SerializeField] private TextMeshProUGUI textoMonedas;
    [SerializeField] private TextMeshProUGUI textoChiperos;

    [SerializeField]
    [Range(10, 2000)]
    private int costoChipa;

    [SerializeField]
    [Range(100, 2000)]
    private int costoChipero;

    [SerializeField] private GameObject chiperoPrefab;


    [SerializeField]
    [Range(10, 2000)]
    private int monedas;

    private int cantidadChipas;
    private int cantidadChiperos;

    void Start()
    {
        cantidadChipas = 0;
        ActualizarTextoMonedas();
    }

    private void ActualizarTextoMonedas()
    {
        textoMonedas.text = monedas.ToString();
    }

    public void ComprarChipa()
    {
        if (costoChipa <= monedas)
        {
            cantidadChipas++;
            monedas -= costoChipa;
            ActualizarTextoChipas();
            ActualizarTextoMonedas();
        }
    }

    private void ActualizarTextoChipas()
    {
        textoChipa.text = "x " + cantidadChipas;
    }

    private void ActualizarTextoChiperos()
    {
        textoChiperos.text = "x " + cantidadChiperos;
    }

    private void OnMouseDown()
    {
        /*
        if (panelGestion.activeSelf)
        {
            panelGestion.SetActive(false);
        }
        else
        {
            panelGestion.SetActive(true);
        }
        */

        panelGestion.SetActive(!panelGestion.activeSelf);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (cantidadChipas == 0) return;

        cantidadChipas--;
        monedas += 10;
        ActualizarTextoMonedas();
        ActualizarTextoChipas();
    }

    public void SumarChipa(int cantidad)
    {
        cantidadChipas += cantidad;
        ActualizarTextoChipas();
    }

    public void Contratar()
    {
        if (costoChipero <= monedas)
        {
            monedas -= costoChipero;
            ActualizarTextoMonedas();
            cantidadChiperos++;
            ActualizarTextoChiperos();
            GameObject chipero = Instantiate(chiperoPrefab);
            chipero.transform.position += Vector3.right * cantidadChiperos;
        }
    }
}
