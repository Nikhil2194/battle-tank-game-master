using UnityEngine;

public class TankModel 
{
    private TankController tankController;


    public  TankModel()
    {
       

    }

    public void SetTankController(TankController _tankController)   //Setters
    {
        tankController = _tankController;
    }
}
