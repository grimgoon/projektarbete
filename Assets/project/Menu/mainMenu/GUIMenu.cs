using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour 
{

    public GUISkin mSkin; // Används för att lägga till GUI-Skinet "Fantasy Buttons GUI" till prefaben "GUIMenu".
	public bool buttonPlay; // registrerar om knappen "play" blir tryckt vilket ger värdet true som används för att koppla en handling till knappen.
	public bool buttonOptions; // - || - 
	public bool buttonExit;  // - || -
	public float native_width = 1920;
	public float native_height = 1080;
	
	    public void OnGUI()
    {
        if (mSkin != null) // Om inget GUI-Skin är valt så använder det ett default skin som är inbyggt i Unity. 
        {
            GUI.skin = mSkin;
        }
		

		GUILayout.BeginArea( new Rect((Screen.width/2)-192, (Screen.height/2)-80, 512, 400)); // Väljer storlek & Position - (X,Y,bredd, höjd);
			GUILayout.BeginVertical("window"); // Startar en vertikal kontrollgrupp, "Window" avser vilket del av skinet som skall användas för kontrollgruppen
				buttonPlay = GUILayout.Button("Play"); // Knapp
				GUILayout.FlexibleSpace(); //Flexible space skapar ett mellanrum som är beroende på hur mycket utrymme som finns över utav rektangelen (Rect) som man ritat upp.
				buttonOptions = GUILayout.Button("Options"); //Knapp
				GUILayout.FlexibleSpace(); // Mellanrum
				buttonExit = GUILayout.Button ("Exit"); //Knapp
			GUILayout.EndVertical(); // Avslutar den vertikala kontrollgruppen
        GUILayout.EndArea(); // Avslutar Området
		
		
		if (buttonPlay == true) // Vad som sker om man trycker på knappen button "Play".
			Application.LoadLevel("playerhouse"); // Skickar en till scenen "playerhouse"
		
		if (buttonOptions == true) // -||-
			Application.LoadLevel("menuOptions"); // skickar en till scenen "menuOptions"
		
		if (buttonExit == true) // -||-
			Application.Quit(); // Stänger av programmet.
    }
}

