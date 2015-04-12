using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;


[System.Serializable]
public class Response {
	public string userName;
	public int userTotalVotes;
	public Sprite favIcon;
	public Sprite plusIcon;
	public int numVotes;
	
}


public class CreateDynResponses : MonoBehaviour {


	public GameObject sampleResponse;
	public Transform contentPanel;
	public List<Response> responses;

	// Use this for initialization
	void Start () {
		PopulateResponses();
	}

	public void PopulateResponses(){
		foreach(var resp in responses){
			GameObject newResponse = Instantiate(sampleResponse) as GameObject;
			SampleResponse sampleRespons0 = newResponse.GetComponent<SampleResponse>();
			sampleRespons0.userName.text = resp.userName;
			sampleRespons0.userTotalVotes.text = resp.userTotalVotes.ToString ();
			sampleRespons0.favIcon.sprite = resp.favIcon;
			sampleRespons0.plusIcon.sprite = resp.plusIcon;
			sampleRespons0.totalVotesForThisResponse.text = resp.numVotes.ToString();
			sampleRespons0.transform.SetParent(contentPanel);

		}
	}
	

}
