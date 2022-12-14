using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
[RequireComponent(typeof(LineRenderer))]
public class RayCastGunScript : MonoBehaviour
{
    public GameoverScript GameOverScreen;
    public Camera playerCamera;
    public Transform laserOrigin;
    public float gunRange=50f;
    public float fireRate = 0.2f;
    public float laserDuretion = 0.05f;
    LineRenderer laserLine;
    float fireTimer;
    public static int tinte = 0;
    public TMP_Text tinteText;
    private void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        fireTimer += Time.deltaTime;
        if(Input.GetButtonDown("Fire1")&&fireTimer>fireRate)
        {
            fireTimer = 0;
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if(Physics.Raycast(rayOrigin,playerCamera.transform.forward,out hit,gunRange))
            {
                laserLine.SetPosition(1, hit.point);
                if (hit.transform.gameObject.CompareTag("Tinta"))
                {
                    Destroy(hit.transform.gameObject);
                    Tinte();
                   // tinte++;
                   // tinteText.text = "Tinte Distruse: " + tinte;
                }
            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
                
            }
            StartCoroutine(ShootLaser());
        }
    }
    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuretion);
        laserLine.enabled = false;
    }
    public void Tinte()
    {
        tinte++;
        tinteText.text = "Tinte Distruse: " + tinte;
        GameOverScreen.tinte(tinte);
    }
}
