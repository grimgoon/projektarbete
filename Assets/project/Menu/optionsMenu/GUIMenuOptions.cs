using UnityEngine;
using System.Collections;

public class GUIMenuOptions : MonoBehaviour 
{

    public GUISkin mSkin; // Används för att lägga till GUI-Skinet "Fantasy Buttons GUI" till prefaben "GUIMenu".
	public bool buttonBack;  // // registrerar om knappen "Back" blir tryckt vilket ger värdet true som används för att koppla en handling till knappen. 
	    public void OnGUI()
    {
		GUI.matrix = GUIGlobals.GetGUIMatrix(); // En matrix som rescalar all GUI för menyn beroende på upplösning genom att använda sig utav GUIGlobals filen.
		
        if (mSkin != null) // Om inget GUI-Skin är valt så använder det ett default skin som är inbyggt i Unity. 
        {
            GUI.skin = mSkin;
        }
		
		GUILayout.BeginArea( new Rect((GUIGlobals.screenWidth/2.7f), (GUIGlobals.screenHeight/2), GUIGlobals.screenWidth * 0.26f, GUIGlobals.screenHeight * 0.37f)); // Väljer storlek & Position - (X,Y,bredd, höjd);
			GUILayout.BeginVertical("window"); // Startar en vertikal kontrollgrupp, "Window" avser vilket del av skinet som skall användas för kontrollgruppen
				GUILayout.FlexibleSpace(); //Flexible space skapar ett mellanrum som är beroende på hur mycket utrymme som finns över utav rektangelen (Rect) som man ritat upp.
				buttonBack = GUILayout.Button("Back"); //Knapp
			GUILayout.EndVertical(); // Avslutar den vertikala kontrollgruppen
        GUILayout.EndArea(); // Avslutar Området
		
		
		if (buttonBack == true) // Vad som sker om man trycker på knappen "Back".
			Application.LoadLevel("menu"); // Skickar en tillbaka till huvudmenyn.
		
    }
}

