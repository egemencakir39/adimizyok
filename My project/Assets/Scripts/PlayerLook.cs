using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // Fare hassasiyeti
    public Transform player; // Oyuncunun Transform bile�eni

    private float rotationX = 0;
    private float rotationY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Fareyi ekran�n merkezine kilitler
        Cursor.visible = false; // Fareyi gizler
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Dikey d�n��
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90); // Dikey s�n�rlar

        // Yatay d�n��
        rotationY += mouseX;

        // Kameran�n yatay ve dikey d�n���n� ayarla
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);

        // Oyuncunun y�n�n� ayarla (sadece yatay d�n��)
        player.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}