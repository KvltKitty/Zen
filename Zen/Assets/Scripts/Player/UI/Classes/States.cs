using UnityEngine;
using System.Collections;

public class States 
{
	public Node[] nodes = new Node[6];
	public States()
	{
		for(int i = 0; i < 6; i++){
			nodes[i] = new Node();
		}
		nodes[0].text[0] = "Transform";
		nodes[0].text[1] = "Back";
		nodes[0].text[2] = "Inventory";
		nodes[0].text[3] = "Interact";
		nodes[0].nextY = 1;
		nodes[0].nextX = 2;
		nodes[0].nextA = 3;
		nodes[1].text[0] = "Dirt";
		nodes[1].text[1] = "Back";
		nodes[1].text[2] = "Sand";
		nodes[1].text[3] = "Stone";
		nodes[1].nextY = 4;
		nodes[1].nextB = 0;
		nodes[1].nextA = 4;
		nodes[1].nextX = 4;
		nodes[2].text[0] = "Move";
		nodes[2].text[1] = "Back";
		nodes[2].text[2] = "Drop";
		nodes[2].text[3] = "Misc";
		nodes[2].nextY = 5;
		nodes[2].nextB = 0;
		nodes[2].nextX = 5;
		nodes[2].nextA = 5;
		nodes[3].text[0] = "Misc";
		nodes[3].text[1] = "Back";
		nodes[3].text[2] = "Misc";
		nodes[3].text[3] = "Misc";
		nodes[3].nextB = 0;
		nodes[4].text[0] = "Flat";
		nodes[4].text[1] = "Back";
		nodes[4].text[2] = "Ramp";
		nodes[4].text[3] = "";
		nodes[4].nextB = 1;
		nodes[5].text[0] = "";
		nodes[5].text[1] = "Back";
		nodes[5].text[2] = "";
		nodes[5].text[3] = "Confirm";
		nodes[5].nextB = 2;
	}
	public int curState = 0;


	public void FireX(){
		if(nodes[curState].nextX >= 0){
			curState = nodes[curState].nextX;
		}
	}
	public void FireY(){
		if(nodes[curState].nextY >= 0){
			curState = nodes[curState].nextY;
		}
	}
	public void FireB(){

		if(nodes[curState].nextB >= 0){
			curState = nodes[curState].nextB;
		}
	}
	public void FireA(){
		if(nodes[curState].nextA >= 0){
			curState = nodes[curState].nextA;
		}
	}




}
