using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinColorController : MonoBehaviour
{
    [SerializeField] private GameObject _coinObject;
    [SerializeField] private Slider _sliderRColor;
    [SerializeField] private Slider _sliderGColor;
    [SerializeField] private Slider _sliderBColor;

    private void Update()
    {
        _coinObject.GetComponentInChildren<MeshRenderer>().material.color =
            new Color(_sliderRColor.value, _sliderGColor.value, _sliderBColor.value);
    }

    public void OnColButtonClick()
    {
        _sliderRColor.value = Random.Range(0, _sliderRColor.maxValue);
        _sliderGColor.value = Random.Range(0, _sliderGColor.maxValue);
        _sliderBColor.value = Random.Range(0, _sliderBColor.maxValue);
    }
}
