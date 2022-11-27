using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChuckNorris : MonoBehaviour
{
  public TextMeshProUGUI jokeText;
    public void NewJoke(){
      Joke j = APIHelper.GetNewJoke();
      Debug.Log(j);
      jokeText.text = j.data[1].value;
    }
}
