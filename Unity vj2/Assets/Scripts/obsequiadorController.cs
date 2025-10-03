using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ChiperoController : MonoBehaviour
{
    [FormerlySerializedAs("tiendaManger")][SerializeField] private TiendaManager tiendaManager;

    private void Start()
    {
        tiendaManager = FindFirstObjectByType<TiendaManager>();
        InvokeRepeating("GenerarChipas", 1, 1);
    }

    /*private void GenerarChipas()
    {
        tiendaManager.SumarChipa(1);
    }*/
}