using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This script is to be assigned to the empty parent object of all the UI buttons
//It will contain all of the functions necessary to shift the UI according to the UI flow diagram
public class playerUI : MonoBehaviour {
	GameObject[] buttons;
	States _states;
	// Use this for initialization
	void Start () {
		buttons = new GameObject[4];
		int i = 0;
		foreach(Transform child in transform){
			buttons[i] = child.gameObject;
			i++;
		}
		foreach(GameObject child in buttons){
			//Debug.Log (child.name);
		}
		_states = new States();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void receiveKey(string input)
	{
		Debug.Log (input);
		if(input == "A"){
			_states.FireA();
		}
		else if(input == "B"){
			_states.FireB ();
		}
		else if(input == "Y"){
			_states.FireY ();
		}
		else if(input == "X"){
			_states.FireX ();
		}
		updateText ();
	}

	void updateText(){
		buttons[0].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Text>().text = _states.nodes[_states.curState].text[2];
		buttons[1].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Text>().text = _states.nodes[_states.curState].text[0];
		buttons[2].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Text>().text = _states.nodes[_states.curState].text[1];
		buttons[3].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Text>().text = _states.nodes[_states.curState].text[3];
	}
}
