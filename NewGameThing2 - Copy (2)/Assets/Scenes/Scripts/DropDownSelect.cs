using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropDownSelect : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static string valueText = "";
    public Text textBox;
	public TMPro.TMP_Dropdown myDrop; 
    
    public void ChangeLocationDropDown()
    {
        Debug.Log(valueText);
        Dropdown m_Dropdown;
        m_Dropdown = GetComponent<Dropdown>();
        Debug.Log(m_Dropdown.options[m_Dropdown.value].text);


        //store in variable
        valueText = m_Dropdown.options[m_Dropdown.value].text;
        //set textbox value
        textBox.text = valueText;
    }

	/*public int returnfunny()
    {
        return myDrop.value;
    }

    /*public string bruhbruh()
    {
        return valueText;
    }

    */
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(myDrop.value);
    }
}
