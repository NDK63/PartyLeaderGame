using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastJobScrollText : MonoBehaviour
{
	public Text Judicial;
	public Text Medical;
	public Text Financial;
	public Text Educational;
	public Text Govern;
	public Text Soldier;
	public Text None;
	
    // Start is called before the first frame update
    void Start()
    {
		Judicial.text = "법조계";
		Medical.text = "의료계";
		Financial.text = "재계";
		Educational.text = "교육계";
		Govern.text = "공무원";
		Soldier.text = "군인";
		None.text = "무직";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
