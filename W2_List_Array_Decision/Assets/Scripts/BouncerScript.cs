using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
     int age;
    
    public TextMeshProUGUI ageText, bouncerText;
    
    string welcomeString, entryString, denyString;  //the lines bouncer says to us
    
    // Start is called before the first frame update
    void Start()
    {
        age = Random.Range(18, 26);
        Debug.Log("what is my age? " + age);
        
        //initilaize and show ageText on screen
        ageText.text = "My age: " + age;
        
        //initialize the sting values
        welcomeString = "Welcome! ID please?";
        entryString = "Have fun! Don't drink too much!";
        denyString = "You're too young to enter, kid.";
        
        bouncerText.text = welcomeString;
    }
    
    public void ClickAgeButton()
    {
        Debug.Log("I'm clicking on the new age button");
        
        age = Random.Range(18, 26);     //randomize age number again
        ageText.text = "My age: " + age;        //updating the age on screen
        
        //evertime I click new age button
        //reset the bouncer text to welcome string
        bouncerText.text = welcomeString;
    }

    public void ClickShowIDButton()
    {
        Debug.Log("I'm clicking on the ID button");

        if (age < 21)
        {
            bouncerText.text = denyString;
        }
        else
        {
            bouncerText.text = entryString;
        }
    }
}
