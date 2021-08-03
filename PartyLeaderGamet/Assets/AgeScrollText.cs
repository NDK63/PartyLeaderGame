using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeScrollText : MonoBehaviour
{
	public Text T30;
	public Text T35;
	public Text T40;
	public Text T45;
	public Text T50;
	public Text T55;
	public Text T60;
	public Text T65;
	public Text T70;
	
    // Start is called before the first frame update
    void Start()
    {
		T30.text = "30";
		T35.text = "35";
		T40.text = "40";
		T45.text = "45";
		T50.text = "50";
		T55.text = "55";
		T60.text = "60";
		T65.text = "65";
		T70.text = "70";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
