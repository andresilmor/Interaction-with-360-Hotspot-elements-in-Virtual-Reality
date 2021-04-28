using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInformation : MonoBehaviour
{
    [Header("Object Information")]
    [SerializeField] InformationDisplay informationDisplay;
    [SerializeField] string information = "";

    public void ShowInformation() {
        if (information.Trim().Length == 0)
            information = "[REDACTED]";
        informationDisplay.DisplayInformation(information);
    }
}
