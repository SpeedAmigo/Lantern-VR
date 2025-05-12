using TMPro;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private int codeNumber = 12345;
    
    public void AddNumber(int number)
    {
        if (inputField.text.Length >= 5) return; 
        inputField.text += number.ToString();
    }

    public void RemoveNumber()
    {
        if (inputField.text.Length <= 0) return;
        inputField.text = inputField.text.Remove(inputField.text.Length - 1);
    }

    public void CheckCode()
    {
        if (inputField.text == codeNumber.ToString())
        {
            Debug.Log("Code is correct");
        }
    }
}
