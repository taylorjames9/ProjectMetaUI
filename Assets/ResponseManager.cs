using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResponseManager : MonoBehaviour {

	public  GameObject responsePrefab;
	private int responseCount;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonUp("Submit")){
			createNewResponse();

		}
	
	}


	public void createNewResponse(){
		Debug.Log ("Response");

		//GameObject responseObj = Instantiate(response) as GameObject;
		//responseObj.transform.SetParent(GameObject.Find ("ActiveArea_Panel").transform);
		//responseObj.GetComponent<RectTransform>().localScale = new Vector2(1,1);
		//responseObj.GetComponent<RectTransform>().localPosition = new Vector3 (0, responseCount * -2, 0);

		//create a new item, name it, and set the parent
		GameObject newItem = Instantiate(responsePrefab) as GameObject;
		newItem.name = gameObject.name + " item at (" + responseCount + ")";
		//newItem.transform.SetParent(GameObject.Find ("Canvas").transform);
		
		//move and size the new item
		RectTransform rectTransform = newItem.GetComponent<RectTransform>();
		
		rectTransform.localScale = new Vector2(1,1);
		rectTransform.localPosition = new Vector3 (0, responseCount * -100, 0);


		responseCount++;
	}


}
