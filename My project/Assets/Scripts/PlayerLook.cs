using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // Fare hassasiyeti
    public Transform player; // Oyuncunun Transform bileþeni

    private float rotationX = 0;
    private float rotationY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Fareyi ekranýn merkezine kilitler
        Cursor.visible = false; // Fareyi gizler
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Dikey dönüþ
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90); // Dikey sýnýrlar

        // Yatay dönüþ
        rotationY += mouseX;

        // Kameranýn yatay ve dikey dönüþünü ayarla
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);

        // Oyuncunun yönünü ayarla (sadece yatay dönüþ)
        player.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}