using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    public TankView tankview;
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel, tankview);
    }

    
}
