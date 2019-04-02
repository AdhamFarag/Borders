using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI; 


public class testAD : MonoBehaviour 
{
	public int credits;
	public void Update(){
		credits = PlayerPrefs.GetInt ("secondchance");
	}
	public void ShowRewardedAd()
	{

		if (Advertisement.IsReady ("rewardedVideo")) 
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show ("rewardedVideo", options);

		} 
		else 
		{
			ResultAction(0, "Ad Not Available");
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log("The ad was successfully shown.");
			ResultAction(3, "Credits Earned!");
			break;
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
		//	ResultAction(0, "Ad Skipped");
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
		//	ResultAction(0, "Ad Failed...");
			break;
		}
	}

	private void ResultAction(int creditsAdd, string resultMessage)
	{
		credits = 1;
		PlayerPrefs.SetInt ("secondchance", credits);


	}







}
