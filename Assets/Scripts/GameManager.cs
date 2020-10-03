
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

bool hasEnded = false;
public float restartDelay = 2f;
public void endgame (){
	if(hasEnded==false){
	hasEnded=true;
	Debug.Log("vgfg");
	Invoke("Restart",restartDelay);
	}
}

public void Restart(){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
}
