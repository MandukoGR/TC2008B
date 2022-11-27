using UnityEngine; //Para la clase JsonUtility
using System.Net;
using System.IO;

public class APIHelper
{
  public static Joke GetNewJoke()
  {
      HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://localhost:8585/step");

      HttpWebResponse response = (HttpWebResponse) request.GetResponse();
      Debug.Log(response);
      StreamReader reader = new StreamReader(response.GetResponseStream());

      string json = reader.ReadToEnd();

      return JsonUtility.FromJson<Joke>(json);
  }
}
