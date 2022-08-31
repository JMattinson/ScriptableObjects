using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class coolCheck : MonoBehaviour
{
    public BoolData cool;
    public Text coolLabel;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCoolLabel();
    }

    public void UpdateCoolLabel()
    {
        coolLabel.text = ("Is the Player cool? " + cool.value.ToString(CultureInfo.InvariantCulture));
    }
    
}
