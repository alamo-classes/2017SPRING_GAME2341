using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
//    public static int score;
////    public static int enemies;
//    public static int systems;
//    public static int health;
//    public static bool weapon;
//    public static bool link;
//
//    public Text enemyText;
//    public Text healthText;
//    public Text weaponText;
//    public Text scoreText;
//    public Text systemsText;
//    public Text linkText;
//
//	private int enemies;
//	private float wait2Update = 1f;
//	private float updateTime;
//
//
//    // Use this for initialization
//    void Start ()
//    {
//		updateTime = Time.time + wait2Update;
//    }
//
//// Update is called once per frame
//void Update ()
//    {
//		if (Time.time > updateTime)
//		{
//			updateTime = Time.time + wait2Update;
//			enemyText.text = "enemies: " + enemyUpdate();
//			healthText.text = "player health: " + health + "%";
//			if (health < 25 && systems > 10)
//			{
//				healthText.color = Color.yellow;
//			}
//			if (health < 11)
//			{
//				healthText.color = Color.red;
//			}
//
//			scoreText.text = "Score: " + score;
//		}
//    }
//
//	int enemyUpdate()
//	{
//		int enemyCnt;
//		GameObject[] badTanks = GameObject.FindGameObjectsWithTag ("EnemyTank");
//		GameObject[] wetTanks = GameObject.FindGameObjectsWithTag ("TankWet");
//		enemyCnt = badTanks.Length + wetTanks.Length;
//		if (enemyCnt < 1)
//		{
//			//TODO win condition
//			Cursor.lockState = CursorLockMode.None;
//			Cursor.visible = true;
//			//SceneManager.LoadScene(2);  // you win screen
//			Invoke("loadWinScreen", 1f);
//		}
//		return enemyCnt;
//	}
//
//	private void loadWinScreen()
//	{
//		SceneManager.LoadScene(2);  // you win screen
//	}
}
