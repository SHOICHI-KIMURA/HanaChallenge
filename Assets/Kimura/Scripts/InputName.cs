using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public Text inputText;
    public InputField inputField;
    public void EndInputText()
    {
        Debug.Log(inputField.text);
        inputField.text = ("");
    }
    public void RealTimeEdit()
    {
        inputText.text = inputField.text;
    }
}
