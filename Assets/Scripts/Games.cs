using UnityEngine;

public class Games : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    private static bool isGameStarted = false;
    
     public void Start()
     {
         CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
     }

    // Update is called once per frame
    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        isGameStarted = true;
    }

	public static bool IsGameStarted()
	{
		return isGameStarted;
	}
}
