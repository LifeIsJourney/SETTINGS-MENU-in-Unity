using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    Animator animator;
 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
   
    }

    public void ChangeAnimation(int valueChange)
    {
        if(valueChange == 0)
        {
            
          animator.CrossFade("SettingButtonClick", 0.5f,0);
        } if(valueChange == 1)
        {
             animator.CrossFade("StatButtonClick", 0.5f,0);

        } if(valueChange == 2)
        { animator.CrossFade("ShopButtonClick", 0.5f);

        } if(valueChange == 3)
        {  animator.CrossFade("CreditButtonClick", 0.5f);
        }
    }
    public void OnExitButtonClick()
    {
        animator.SetTrigger("Exit");
    }
    public void DisbleThisGameObject()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
