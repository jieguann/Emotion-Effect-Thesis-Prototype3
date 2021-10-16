using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmotionFerPlus;

public class emotionConnection : MonoBehaviour
{
    public Material material;
    //public Test test;
    public Test test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("RedFloat", test.angry);
        material.SetFloat("OrangeFloat", test.afraid);
        material.SetFloat("YellowFloat", test.surprised);
        material.SetFloat("GreenFloat", test.happy);
        material.SetFloat("BlueFloat", test.sad);
        material.SetFloat("PurpleFloat", test.anxious);
        material.SetFloat("WhiteFloat", test.neutral);


    }
}
