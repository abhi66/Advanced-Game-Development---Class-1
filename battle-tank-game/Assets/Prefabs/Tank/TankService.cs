using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour {

   public TankView tankView;
  
    void Start () {
        CreateTank(new Vector3(0, 0, 0));
        CreateTank(new Vector3(0, 0, -4));
        CreateTank(new Vector3(5, 0, -2));
    }


    void CreateTank(Vector3 transform){
    TankModel tankModel = new TankModel(10, 100f);
        tankView.GetComponent<Transform>().position = transform;
    TankController tank = new TankController(tankModel, tankView);
}
	
}
