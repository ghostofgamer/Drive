using UnityEngine;

public class WellFortune : MonoBehaviour
{
    [SerializeField]private  Wallet _wallet;
    
   public float RotatePower;
    public float StopPower;

    private Rigidbody2D rbody;
    int inRotate;
    
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    float t;
    private void Update()
    {           
        
        if (rbody.angularVelocity > 0)
        {
            rbody.angularVelocity -= StopPower*Time.deltaTime;

            rbody.angularVelocity =  Mathf.Clamp(rbody.angularVelocity, 0 , 1440);
        }

        if(rbody.angularVelocity == 0 && inRotate == 1) 
        {
            t +=1*Time.deltaTime;
            if(t >= 0.5f)
            {
                GetReward();

                inRotate = 0;
                t = 0;
            }
        }
    }

    public void Rotete() 
    {
        if(inRotate == 0)
        {
            rbody.AddTorque(RotatePower);
            inRotate = 1;
        }
    }

    public void GetReward()
    {
        float rot = transform.eulerAngles.z;

        if (rot > 0 && rot <= 30)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,15);
            Win(10);
        }
        else if (rot > 30 && rot <= 60)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,45);
            Win(50);
        }
        else if (rot > 60 && rot <= 90)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,75);
            Win(100);
        }
        else if (rot > 90 && rot <= 120)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,105);
            Win(150);
        }
        else if (rot > 120 && rot <= 150)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,135);
            Win(300);
        }
        else if (rot > 150 && rot <= 180)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,165);
            Win(400);
        }
        else if (rot > 180 && rot <= 210)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,195);
            Win(450);
        }
        else if (rot > 210 && rot <= 240)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,225);
            Win(500);
        }
        else if (rot > 240 && rot <= 270)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,255);
            Win(550);
        }
        else if (rot > 270 && rot <= 300)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,285);
            Win(600);
        }
        else if (rot > 300 && rot <= 330)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,315);
            Win(650);
        }
        else if (rot > 330 && rot <= 360)
        {
            // GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,345);
            Win(1000);
        }
    }

    public void Win(int Score)
    {
        _wallet.IncreaseDiamonds(Score);
        print(Score);
    }
}
