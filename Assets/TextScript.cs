using UnityEngine;
using TMPro;  
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public TMP_Text CarPassedText;  

    void Start()
    {
        // Kontrollera om CarPassedText är tilldelad i Inspector
        if (CarPassedText == null)
        {
            //Debug.LogError("CarPassedText is not assigned in the Inspector!");
        }
    }


}
