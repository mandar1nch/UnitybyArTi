using UnityEngine;
using System;


public class playerresource2 : MonoBehaviour
{
    public static playerresource2 Find(string name)
    {
        foreach (var resource in FindObjectsOfType<playerresource2>())
        {
            if (resource.resourceName == name)
            {
                return resource;
            }
        }
        return null;
    }

    [SerializeField] private float value = 0;
    [SerializeField] private float maxValue = 9999; // ДОБАВЛЕНО
    public float GetValue() => value;
    public float GetMaxValue() => maxValue; // ДОБАВЛЕНО

    public string resourceName = "money";

    public void ChangeValue(float change)
    {
        value = Mathf.Clamp(value + change, 0, maxValue); // ИЗМЕНЕНО
        if (ValueChangeEvent != null)
        {
            ValueChangeEvent(value);
        }
    }

    public event Action<float> ValueChangeEvent;
}