using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseController : MonoBehaviour {
	//Public Instance Variables
	public GameController gameController;

	public Text CongratulationsLabel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			
			Destroy(gameObject);
			this.CongratulationsLabel.gameObject.SetActive (true);
			//gameController.LivesValue = 0;
		}
	}
}
