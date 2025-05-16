using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScreenScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private int codeNumber = 1234;
    
    [SerializeField] private UnityEvent onCodeCorrect;
    
    public void AddNumber(int number)
    {
        if (inputField.text.Length >= 4) return; 
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
            onCodeCorrect?.Invoke();
            inputField.text = "_";
        }
    }
}
