using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRotateController : MonoBehaviour
{
    [SerializeField] private GameObject _coinObject;
    [SerializeField] private Slider _sliderXRotation;
    [SerializeField] private Slider _sliderYRotation;
    [SerializeField] private Slider _sliderZRotation;

    private void Update()
    {
        _coinObject.transform.Rotate(_sliderXRotation.value, _sliderYRotation.value, _sliderZRotation.value);
    }

    public void OnRandButtonClick()
    {
        _sliderXRotation.value = Random.Range(0, _sliderXRotation.maxValue);
        _sliderYRotation.value = Random.Range(0, _sliderYRotation.maxValue);
        _sliderZRotation.value = Random.Range(0, _sliderZRotation.maxValue);       
    }
}
