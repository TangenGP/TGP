using UnityEngine;
using System.Collections;

public class FloatingTextController : MonoBehaviour {

    private static FloatingText popupText;
    private static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.FindGameObjectWithTag("Damage");
        if(!popupText)
            popupText = Resources.Load<FloatingText>("Prefabs/PopupTextParent"); //Leter da gjennom Ressursmappa så Prefabs for å så finne texten
    }

    public static void CreateFloatingText(string text, Transform location)
    {
        FloatingText instance = Instantiate(popupText); //Aktivere popupText
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);

        instance.transform.SetParent(canvas.transform, false);
        //instance.transform.position = screenPosition;
        //instance.transform.localPosition = new Vector2(0,0);
        instance.SetText(text);
    }
}
