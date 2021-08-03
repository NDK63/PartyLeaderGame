using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegionScrollText : MonoBehaviour
{
	public Text Seoul;
	public Text Busan;
	public Text Incheon;
	public Text Gwangju;
	public Text Daegu;
	public Text Ulsan;
	public Text Daejeon;
	public Text Jeju;
	public Text Gyeonggi;
	public Text Gyeongbuk;
	public Text Gyeongnam;
	public Text Jeonbuk;
	public Text Jeonnam;
	public Text Chungbuk;
	public Text Chungnam;
	public Text Gangwon;
   
   // Start is called before the first frame update
    void Start()
    {	
		Seoul.text = "서울";
		Busan.text = "부산";
		Incheon.text = "인천";
		Gwangju.text = "광주";
		Daegu.text = "대구";
		Ulsan.text = "울산";
		Daejeon.text = "대전";
		Jeju.text = "제주";
		Gyeonggi.text = "경기";
		Gyeongbuk.text = "경북";
		Gyeongnam.text = "경남";
		Jeonbuk.text = "전북";
		Jeonnam.text = "전남";
		Chungbuk.text = "충북";
		Chungnam.text = "충남";
		Gangwon.text = "강원";
	}
}
