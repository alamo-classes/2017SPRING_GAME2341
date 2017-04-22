using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
//    public int startingHealth = 100;
//    private int currentHealth;
//    public Image damageImage;
////    public AudioClip deathClip;
//    public float flashTime = 5f;
//    public Color flashColour = new Color(1f, 0f, 0f, .2f);
//    private float damageTime = .5f;
//    private float showDamageNot = 0;
//
//
////    Animator anim;
////    AudioSource playerAudio;
//    bool damaged = false;
//
//
//    void Awake()
//    {
//        currentHealth = startingHealth;
//		UIManager.health = currentHealth;
//    }
//		
//    void Update()
//    {
//        if (damaged)
//        {
//            damageImage.color = flashColour;
//            //Debug.Log("Player Hit: "+ damageImage);
//            showDamageNot = Time.time + damageTime;
//            damaged = false;
//        }
//
//        if(Time.time > showDamageNot)
//        {
//            damageImage.color = Color.Lerp(damageImage.color, Color.clear, 1);
//        }
//    }
//		
//    public void TakeDamage(int amount)
//    {
//        damaged = true;
//        currentHealth -= amount;
//        //        playerAudio.Play();
//        UIManager.health = currentHealth;
//
//        if (currentHealth <= 0)
//        {
//            Death();
//        }
//    }
//
//    void Death()
//    {
//        //anim.SetTrigger("Die");
//
//        //playerAudio.clip = deathClip;
//        //playerAudio.Play();
//        Cursor.lockState = CursorLockMode.None;
//        Cursor.visible = true;
//        HeroineCntlr.hasBlaster = false;
//        SceneManager.LoadScene(3);  // you lose screen
//    }
}
