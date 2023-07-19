using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextUpdater : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] private TextMeshProUGUI messageLabel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        //messageLabel.text = messageLabel.text += "lalalalalala" + message;

        // populates a message and adds to line of text
        messageLabel.text += "\nlalalalalala" + message;

        // 
    
    }

}
