using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UserInputField : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _inputField;
    
    private TMP_Text _text;


    public void OnValueChanged()
    {
        var userName = _inputField.text;
        GameManagerSample.Instance.SetName(userName);
    }

}
