using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerJC : MonoBehaviour
{
    public VariableJoystick joystick;
    public float speed = 10;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public int count;

    Rigidbody rb;
    Vector3 playerInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerInput.x = joystick.Horizontal * speed;
        playerInput.z = joystick.Vertical * speed;
        playerInput.y = rb.velocity.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 7)
        {
            winTextObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = playerInput;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            AnalyticHandler.instance.sendpickUp();
        }

        if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
            AnalyticHandler.instance.sendpickUp5();

        }
        if (other.gameObject.GetComponent<IntersitialAdExample>())
        {
            other.gameObject.GetComponent<IntersitialAdExample>().ShowInterstitalAD();
        }
    }
}
