using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlashingText : MonoBehaviour {

    Text flashingText;
    public string textToFlash = "";
    string blankText = "";
    string staticText = "";
    //flag to determine if you want the blinking to happen
    bool isBlinking = true;

    void Start()
    {
        //get the Text component
        flashingText = GetComponent<Text>();
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkText());
        //call function to check if it is time to stop the flashing.
        //StartCoroutine(StopBlinking());
    }

    //function to blink the text 
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement. Here you can just set the isBlinking flag to false whenever you want the blinking to be stopped.
        while (isBlinking)
        {
            //set the Text's text to blank
            flashingText.text = blankText;
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display “I AM FLASHING TEXT” for the next 0.5 seconds
            flashingText.text = textToFlash;
            yield return new WaitForSeconds(.5f);
        }
    }
    //your logic here. I have set the isBlinking flag to false after 5 seconds
    IEnumerator StopBlinking()
    {
        //wait for 5 seconds
        yield return new WaitForSeconds(5f);
        //stop the blinking
        isBlinking = false;
        //set a different text just for sake of clarity
        flashingText.text = staticText;
    }
}
