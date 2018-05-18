using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int power = 25;

	public int mp = 53;

	public void Magic(){

		if (mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		}else{
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");	
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");

		this.hp -= damage;
	}




}

public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {
		int[] array = {1,3,5,7,9};

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
			
		}

		for (int i1 = 4; i1 >= 0; i1--) {
			Debug.Log (array [i1]);
			
			
		}

		Boss lastboss = new Boss ();

		for (int i2 = 0;i2 < 11;i2++) {
			lastboss.Magic ();
		}
			

		lastboss.Attack ();

		lastboss.Defence (3);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
