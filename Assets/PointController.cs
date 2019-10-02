using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointController : MonoBehaviour {

	//pointを表示するテキスト
	private GameObject pointText;
	//変数
	private int point = 0;
	//public Text pointText;

	// Use this for initialization
	void Start () {
		point = 0;//初期値

		this.pointText = GameObject.Find ("PointText");
		//pointText.text = point.ToString ();		//Pointを変換
		//GameObject.Find("PointText")=pointText.text;
		//this.pointText.GetComponent<Text> ().text = pointText.text;

		SetPoint();
	}

	// Update is called once per frame
	void Update () {
		
	}
	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision collision) {
		string yourtag = collision.gameObject.tag;

		Debug.Log (collision.gameObject.name);
		Debug.Log (point.ToString());

		// タグによって点数を変える
		if (yourtag == "SmallStarTag") {
			point +=  1;
		} else if ( yourtag == "LargeStarTag") {
			point +=  5;
		} else if ( yourtag == "SmallCloudTag") {
			point += 10;
		} else if ( yourtag == "LargeCloudTag"){
			point += 20;
		}

		SetPoint ();

	}

	void SetPoint(){
		this.pointText.GetComponent<Text> ().text = point.ToString ();

	}



}
