using UnityEngine.SceneManagement;
using UnityEngine;


public class Credits : MonoBehaviour {
		public void Playagain()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
}
public void Appquit()
{
	Application.Quit();
}

}
