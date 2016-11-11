using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private GameObject wheelBG, slice1, slice2, slice3, slice4, slice5, slice6, slice7, slice8;
	private List<Image> slices = new List<Image>();


	void Start(){
	
		wheelBG = GameObject.Find ("WheelBG");
		slice1 = GameObject.Find ("Slice1");
		slice2 = GameObject.Find ("Slice2");
		slice3 = GameObject.Find ("Slice3");
		slice4 = GameObject.Find ("Slice4");
		slice5 = GameObject.Find ("Slice5");
		slice6 = GameObject.Find ("Slice6");
		slice7 = GameObject.Find ("Slice7");
		slice8 = GameObject.Find ("Slice8");
		slices.Add (slice1.GetComponent<Image>());
		slices.Add (slice2.GetComponent<Image>());
		slices.Add (slice3.GetComponent<Image>());
		slices.Add (slice4.GetComponent<Image>());
		slices.Add (slice5.GetComponent<Image>());
		slices.Add (slice6.GetComponent<Image>());
		slices.Add (slice7.GetComponent<Image>());
		slices.Add (slice8.GetComponent<Image>());

		SetUpGame ();
	}

	public void SetUpGame(){
		foreach (Image image in slices) {
			image.color = new Color32(51,51,51,255);		
		}
		wheelBG.transform.rotation = Quaternion.Euler(0, 0, 22.5f);

	
	}





}
