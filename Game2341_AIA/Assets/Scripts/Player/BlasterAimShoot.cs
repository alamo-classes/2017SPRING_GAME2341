using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BlasterAimShoot : MonoBehaviour
{
//    public int gunDamage = 5;
//    public float fireRate = .5f;
//    public float weaponRange = 125f;
//    public float hitForce = 100f;
//    public Transform gunEnd;
//    public Camera aimCam;
//    public Animator anim;
//
//    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
//    private AudioSource gunAudio;
//    private LineRenderer laserLine;
//    private float nextFire;
//   
//    void Start()
//    {
//        laserLine = GetComponent<LineRenderer>();
//        gunAudio = GetComponent<AudioSource>();
//    }
//
//
//    void Update()
//    {
//        if (Input.GetButtonDown("Fire1") && (Time.time > nextFire) && HeroineCntlr.targetCamOn && HeroineCntlr.hasBlaster)
//        {
//            nextFire = Time.time + fireRate;
//
//            anim.SetTrigger("shoot");
//            StartCoroutine(ShotEffect());
//
//            Vector3 rayOrigin = aimCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
//            RaycastHit hit;
//            laserLine.SetPosition(0, gunEnd.position);
//
//            if (Physics.Raycast(rayOrigin, aimCam.transform.forward, out hit, weaponRange))
//            {
//                laserLine.SetPosition(1, hit.point);
//  				TankHealth health = hit.collider.GetComponent<TankHealth>();
//
//                if (health != null)
//                {
//					health.TakeDamage(gunDamage);
//                    UIManager.score += 50;
//                }
//
//            }
//            else
//            {
//                laserLine.SetPosition(1, rayOrigin + (aimCam.transform.forward * weaponRange));
//            }
//        }
//    }
//
//    private IEnumerator ShotEffect()
//    {
//        // Play the shooting sound effect
//        gunAudio.Play();
//
//        // Turn on our line renderer
//        laserLine.enabled = true;
//
//        //Wait for .07 seconds
//        yield return shotDuration;
//
//        // Deactivate our line renderer after waiting
//        laserLine.enabled = false;
//    }
}
