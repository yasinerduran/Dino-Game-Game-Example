using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sine : MonoBehaviour
{
    // Hareket hızı
    public float moveSpeed = 1f;

    // Dalga hareketinin genliği (yükseklik)
    public float amplitude = 1f;

    // Dalga hareketinin frekansı (hız)
    public float frequency = 1f;

    // Rigidbody bileşeni
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody bileşenini al
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Zamanı al
        float time = Time.time;

        // Yeni Y pozisyonunu hesapla
        float newY = transform.position.y + Mathf.Sin(time * frequency) * amplitude;

        // Yeni pozisyonu belirle
        Vector3 newPos = new Vector3(transform.position.x -1, newY, transform.position.z);

        // Rigidbody'nin hızını sıfırla (dış etkileri sıfırlamak için)
        rb.velocity = Vector3.zero;

        // Yeni pozisyonu hedef olarak belirle
        rb.MovePosition(Vector3.Lerp(rb.position, newPos, moveSpeed * Time.fixedDeltaTime));
    }
}
