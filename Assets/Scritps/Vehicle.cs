using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class VehicleController : MonoBehaviour
{
    private Vehicle car;
    private Vehicle ship;
    private Vehicle plane;

    private void Start()
    {
        car = new Car();
        ship = new Ship();
        plane = new Plane();
    }
     
     [ContextMenu(nameof(Transport))]
  private void Transport()
    {
        car.Go();
        ship.Go();
        plane.Go();

    }
}
 

  public abstract class Vehicle
{
    public abstract void Go();
}
 public class Car: Vehicle
{
    public override void Go()
    {
        Debug.Log(" Bi Bi ");
    }

}
 
 public class Ship: Vehicle
{
    public override void Go()
    {
        Debug.Log(" Ty Ty ");
    }

}

public class Plane: Vehicle
{
    public override void Go()
    {
        Debug.Log(" Try Try ");
    }

}